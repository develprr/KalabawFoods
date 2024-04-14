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

## Usage 

To run the application in Docker container:
```
docker-compose up -d
```

Then, navigate to the containerized KalabawFoods Blazor app with your browser:
```
localhost:5006
```