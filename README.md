# KalabawFoods Demo Front End 

This is a demo app to showcase how to containerize a Blazor-based
front end application. The user interface is an single page application 
online store implementation of an imaginary start-up company "Kalabaw Foods",
which imports, refines and sells exotic meat products.

## Credits
The Docker configuration in this example is heavily influenced by the following examples:
* https://github.com/kierunb/razorapp-docker
* https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-server-app/

## Usage 

To locally build and run the example app outside the Docker container:
```bash
cd FrontEnd
dotnet build
dotnet run
```

To run the application in Docker container:
```
docker-compose up -d
```
