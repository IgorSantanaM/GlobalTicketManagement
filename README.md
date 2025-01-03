# Clean Architecture with ASP.NET Core  

This project demonstrates a **Clean Architecture** implementation for building robust, maintainable, and scalable web applications using **ASP.NET Core**. It incorporates the **Mediator pattern** and adheres to the **5 principles of architecture** while emphasizing key concepts of building modern web projects.  

## Key Features  

- **Clean Architecture**: Separation of concerns through distinct layers: Presentation, Application, Domain, and Infrastructure.  
- **Mediator Pattern**: Decouples handlers and request processing logic using `MediatR`.  
- **5 Principles of Architecture**: Ensures a solid foundation by following proven architectural principles.  
- **Scalable Design**: Suitable for small to large-scale applications.  
- **Extensibility**: Easy to add new features without impacting existing functionalities.  

## Layers Overview  

### 1. **Domain**  
The **core** layer containing:  
- Business logic.  
- Entities and value objects.  
- Interfaces and domain-specific abstractions.  

### 2. **Application**  
Handles:  
- Use cases and application flow.  
- Command and query handling via **Mediator pattern**.  
- Validation and business rules implementation.  

### 3. **Infrastructure**  
Manages external concerns like:  
- Database access.  
- External APIs and services.  
- File storage, logging, etc.  

### 4. **Presentation**  
Provides:  
- APIs for user interaction.  
- Controllers and API endpoints.  
- Input/output models for communication with the application layer.  

## Principles of Architecture  

This project follows the **5 principles of architecture**:  

1. **Separation of Concerns**: Clear boundaries between layers ensure maintainability and simplicity.  
2. **Dependency Inversion**: High-level modules depend on abstractions, not implementations.  
3. **Single Responsibility**: Each layer has a specific purpose.  
4. **Interface Segregation**: Interfaces are designed for specific needs, avoiding unnecessary dependencies.  
5. **Open/Closed Principle**: The system is open to extension but closed to modification.  

## Technologies  

- **ASP.NET Core**: Framework for building the web API.  
- **MediatR**: Implements the mediator pattern for command and query handling.  
- **Entity Framework Core**: Data access with a focus on the repository pattern (optional).  
- **AutoMapper**: Maps objects between layers.  

## Getting Started  

### Prerequisites  
- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later.  
- A compatible IDE (e.g., Visual Studio, Rider, or VS Code).  

### Installation  

1. Clone the repository:  
   ```bash  
   git clone https://github.com/yourusername/yourproject.git  
   cd yourproject
   ```
2. Restore dependencies:

```bash
dotnet restore  
```
3. Update the database (if applicable):

```bash
dotnet ef database update  
```
4. Run the application:

``` bash
dotnet run  
```

## Contributing
Contributions are welcome! Please submit a pull request or open an issue to suggest changes or report bugs.
