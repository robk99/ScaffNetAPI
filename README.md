# ScaffNetAPI
[![License](https://img.shields.io/github/license/robk99/ScaffNetAPI)](LICENSE)

A RESTful API implementation of [ScaffNet](https://github.com/robk99/ScaffNet) that exposes project scaffolding functionality as a web service. ScaffNetAPI provides a robust HTTP interface for generating industry-standard .NET project templates, making it ideal for integration into development workflows and tools.

## Features

- **RESTful Architecture**: 
  - Clean, well-structured API endpoints following REST principles
  - Swagger documentation for easy API exploration
  - Health check endpoint for monitoring

- **Architecture Generation**: 
<br>Clean Architecture:
  - Create complete Clean Architecture solutions via HTTP POST
  - Configurable solution name and path
  - Proper project structure with all necessary layers

- **Cross-Platform Compatibility**:
  - Works on Windows, macOS, and Linux
  - Built on .NET 8.0 for maximum compatibility

- **Robust Error Handling**:
  - Comprehensive error responses
  - Detailed logging for troubleshooting
  - Custom event handling integration

- **Security & Configuration**:
  - CORS policy support
  - HTTPS redirection
  - Configurable allowed origins
  - Environment-specific settings

## API Endpoints

### Health Check
```
GET /health
```
Returns the health status of the API.

### Swagger Documentation
```
GET /swagger
```
Interactive API documentation and testing interface.

### Create Clean Architecture
```
POST /api/create-clean-architecture
```
Creates a new Clean Architecture solution.

Request body:
```json
{
  "solutionName": "string",
  "solutionPath": "string"
}
```

## Installation

1. Clone the repository:
```bash
git clone https://github.com/robk99/ScaffNetAPI.git
```

2. Navigate to the project directory:
```bash
cd ScaffNetAPI
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Run the application:
```bash
dotnet run
```

The API will be available at:
- HTTP: http://localhost:5150
- HTTPS: https://localhost:7059

## Configuration

The application can be configured through `appsettings.json` and environment-specific settings files:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "AllowedOrigins": [
    "http://localhost:4200"
  ]
}
```

## Related Projects

- [ScaffNet](https://github.com/robk99/ScaffNet): The core .NET project scaffolding library
- [ScaffNetConsole](https://github.com/robk99/ScaffNetConsole): A .NET CLI tool that implements ScaffNet as a command-line interface with enhanced visual experience using Spectre.Console.Cli.
- [ScaffNetAngular](https://github.com/robk99/ScaffNetAngular): A modern Angular 18 application that provides a user-friendly interface for ScaffNet.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
