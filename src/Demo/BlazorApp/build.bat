::Build the project
dotnet restore BlazorApp.csproj -c Release
::publish the project
dotnet publish BlazorApp.csproj -c Release -o ./bin/publish
::Build the docker image with version
docker build -t pratapgowda/demo-webapp:%1 .
::Push the docker image
docker push pratapgowda/demo-webapp:%1