# KalabawFoods Demo Front End 

This is the iteration step 2 of our food store demo app "Kalabaw Foods".
In this iteration, we expand the application by adding Product and Category
classes to demonstrate a one-to-many relation. We also added entity framework
support for PostgreSQL database and the first migration to create the initial
tables with some sample data.

The user interface is a SPA (single page application)
that presents the online store of an imaginary start-up company "Kalabaw Foods", which imports, refines and sells exotic meat products.

## Credits
This code is ethically produced.
No restricted, protected or proprietary sources were used to create this code example. No animals were harmed during the process. All created code strictly follows Microsoft's guidelines and is written by only combining the lessons from the following public open source resources:
* https://github.com/kierunb/razorapp-docker
* https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-server-app/
* https://learn.microsoft.com/en-us/training/modules/build-web-api-minimal-database/3-exercise-add-entity-framework-core
* https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
* https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-8.0
* https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
* https://learn.microsoft.com/en-us/ef/core/providers/sql-server/?tabs=dotnet-core-cli
* https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many
* https://ubuntu.com/server/docs/databases-postgresql
* https://jasonwatmore.com/post/2022/06/23/net-6-connect-to-postgresql-database-with-entity-framework-core


## Requirements

* Docker engine - to install the Docker engine, read https://docs.docker.com/engine/install/ubuntu/ 
* .NET SDK - read https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet8&pivots=os-linux-ubuntu-2404

## Usage 

To run the application in Docker container:
```
docker compose up -d
```


Then, navigate to the containerized KalabawFoods Blazor app with your browser:
```
http://localhost:5006
```

## Development 

### Build the front end app

To build the front end app, run at project's root:
```
cd KalabawFoods.FrontEnd
dotnet build
```

### Run the front end app
In `KalabawFoods.FrontEnd` directory, type:
```
dotnet run
```
The command starts the front end app outside the container, yet relying on the database
which resides inside the container. The database container must be up and running for this command to succeed.
To verify whether the database container is up and running, type:

```
docker ps
```

## Migrations

To manage migrations, navigate to project's root with your favorite terminal. From project's root,
navigate to front end app:
```
cd KalabawFoods.Frontend
```

### Listing migrations

in the front end app, type:

```
dotnet ef migrations list
```

# Deployment

To deploy the application to Azure as a containerized app, follow these steps.

## 1. Create a resource group

First create a resourcce group for your application with the following command.
Change the resource group's name to better fit your own scenario. Likewise, change the location
if you are not in North Europe:
```
az group create --name my-food-business-resource-group --location northeurope
```

## 2. Create a registry

Create a registry for your resource group:
```
az acr create --name myfoodbusinessregistry --resource-group my-food-business-resource-group --sku basic --admin-enabled true
```

## 3. Deploy the image

The following command deploys your container app's image to Azure cloud:
```
az acr build --file KalabawFoods.FrontEnd/Dockerfile --registry myfoodbusinessregistry --image myfoodbusiness-image . 
```
