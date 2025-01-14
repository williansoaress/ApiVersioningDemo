# ApiVersioningDemo

## Overview

This is an ASP.NET Core project demonstrating how to implement API versioning using ApiVersioning and VersionedApiExplorer.

## Project Setup

### Requirements

Make sure you have the following items installed on your machine:

- .NET SDK (version 9.0)
- A code editor, such as Visual Studio Code or Visual Studio 2022
- Git (to clone the repository, if applicable)

### Setup Steps

1. Clone the repository (if you don't have the project locally):

    ```bash
    git clone https://github.com/williansoaress/ApiVersioningDemo
    cd ApiVersioningDemo
    ```

2. Restore the necessary packages:

    Run the following command at the root of the project (where the .sln file is located):

    ```bash
    dotnet restore
    ```

    This command will ensure that all project dependencies are downloaded.

3. Build the project to verify everything is set up correctly:

    ```bash
    dotnet build
    ```

4. Run the project locally:

    ```bash
    dotnet run
    ```

    By default, the application will be available at: `https://localhost:7067`.

## Main Dependencies

The following libraries are used in this project:

- **Microsoft.AspNetCore.Mvc.Versioning**: Implements API versioning.
- **Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer**: Provides support for exploring and documenting different API versions.

### Manual Installation of Dependencies

If you need to manually install the dependencies, run the following commands:

```bash
# Install the API versioning package
dotnet add package Microsoft.AspNetCore.Mvc.Versioning

# Install the API version explorer package
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
```

## Project Structure
The project follows a standard ASP.NET Core application structure:
```bash
ApiVersioningDemo/
├── Controllers/           # API Controllers
├── V1/                    # API Version 1
├── V2/                    # API Version 2
├── Properties/            # Project settings
├── Program.cs             # Application entry point
├── ApiVersioningDemo.sln  # Solution file
└── ...                    # Other files and folders
```
Additional Documentation
This project uses API versioning with the following settings:

Deprecate version: 1.0
- URL formatting: https://localhost:7067/api/v1/TestApiVersioning 

Default version: 2.0
- URL formatting: https://localhost:7067/api/v2/TestApiVersioning 

Contributing
If you'd like to contribute to this project:

1. Fork the repository.
2. Create a branch for your feature or fix: git checkout -b my-feature.
3. Push your changes: git push origin my-feature.
4. Open a pull request.

