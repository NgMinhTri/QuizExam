# Quiz Examination Project

## Application URLs:
- Identity STS: https://localhost:5001
- Exam API: https://localhost:5002
- Identity API: https://localhost:5003
- Exam Admin: https://localhost:6001
- Exam Portal: https://localhost:6002
- Identity Admin: https://localhost:6003

## Docker Command Examples
- docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Admin@123$' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
- docker ps or docker container ls
- docker run -d --name mongodb -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Admin@123$ -p 127.0.0.1:27017:27017 mongo

## Packages References
- https://github.com/serilog/serilog/wiki/Getting-Started
- https://github.com/IdentityServer/IdentityServer4.Quickstart.UI
- https://mudblazor.com/
- https://github.com/Garderoben/MudBlazor.Templates

## Install Environments
- https://dotnet.microsoft.com/download/dotnet/3.1
- https://dotnet.microsoft.com/download/dotnet/5.0
- https://visualstudio.microsoft.com/
- https://www.youtube.com/watch?v=fjadnDlo0RA
- https://www.microsoft.com/en-us/sql-server/sql-server-downloads
- https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/
- https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
- https://robomongo.org/


## .NET extensions for VS Code
- .NET Core Add Reference
- .NET Core Test Explorer
- .NET Core Tool
- .NET Core User Secrets
- C#
- C# Extensions
- NuGet Gallery
- NuGet Package Manager