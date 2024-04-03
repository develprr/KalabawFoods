FROM mcr.microsoft.com/dotnet/sdk:8.0 AS restore
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY FrontEnd/KalabawFoodsFrontEnd.csproj FrontEnd/
RUN dotnet restore FrontEnd/KalabawFoodsFrontEnd.csproj

WORKDIR /src
COPY . .
WORKDIR /src/FrontEnd

FROM restore AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
WORKDIR /src/FrontEnd
RUN dotnet build KalabawFoodsFrontEnd.csproj -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish KalabawFoodsFrontEnd.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KalabawFoodsFrontEnd.dll"]