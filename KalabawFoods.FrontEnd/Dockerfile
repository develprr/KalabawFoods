FROM mcr.microsoft.com/dotnet/sdk:8.0 AS restore

ENV ASPNETCORE_ENVIRONMENT Development
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY KalabawFoods.FrontEnd/KalabawFoods.FrontEnd.csproj KalabawFoods.FrontEnd/
RUN dotnet restore KalabawFoods.FrontEnd/KalabawFoods.FrontEnd.csproj

WORKDIR /src
COPY . .
WORKDIR /src/KalabawFoods.FrontEnd

FROM restore AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
WORKDIR /src/KalabawFoods.FrontEnd
ENTRYPOINT dotnet-ef database update --project src/KalabawFoods.FrontEnd/ --startup-project src/KalabawFoods.FrontEnd

RUN dotnet build KalabawFoods.FrontEnd.csproj -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish KalabawFoods.FrontEnd.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KalabawFoods.FrontEnd.dll"]