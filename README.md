# Cloud Library Assessment
This .Net source code contains solution for a cloud library assignment. The assignment is expressed in:
- [Cloud Library Assignment](docs/cloud-library.md)

## Running
```dotnet build```

```dotnet run --project ConsoleUI```

## Notes
This repository contains two project under the names `CloudLibrary` and `ConsoleUI`. The `CloudLibrary` is a .Net class library based on .net standard 2, and contains the main code of the assignment. The second one is a console application that can be used to run the project and see the output.

I used `dot net core` on `Linux` to write this application using `vs code`.

I tried to use some techniques for cleaner and better implementation:
- OOP
- SOLID
- Dependency Injection

As I used abstract classes and interfaces, defining new cloud providers (like AWS, GCP, Azure, ...) and new resources is feasible.
