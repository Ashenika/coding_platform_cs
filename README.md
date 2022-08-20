# coding_platform_cs

**Note:** This project is created using Visual Studio 2019 with .NET SDK 3.1. 

### Folder Structure
```
 project
 |__ project (Functions Goes Here)
    |__ obj/
    |__ bin/
    |__ FunctionOne.cs
    |__ Main.cs
    |__ project.csproj
 |__ project_test (Tests Goes Here)
    |__ bin/
    |__ obj/
    |__ UnitTestOne.cs
    |__ project_test.csproj
 | project.sln
 |__ README.md
```

## Build and Run Unit Tests
### Build
`dotnet build --configuration Release --no-restore`

### Run Unit Tests
`dotnet test`
