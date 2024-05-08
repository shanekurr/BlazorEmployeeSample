# BlazorEmployeeSample

## Description

This is a sample project to demonstrate how to use Blazor with Entity Framework Core and SQL Server. The project is a simple employee management system where you can add, edit and view employees.

## Prerequisites
To run the project, you will need a SQL Server instance with a database that has been built using the included seed scripte.
Add the connection string to user secrets by right clicking on the project and selecting `Manage User Secrets`. Add the following connection string to the `secrets.json` file:

```json
{
	"ConnectionStrings:Employees": "INSERT_YOUR_CONNECTION_STRING_HERE"  
}
```

Please note that if the database is not created, the project will create the database when it is first run.

## Running the project
To run the project, simply clone the repository and run the project in Visual Studio. The project will open in your default browser and you can start adding, editing and viewing employees.

## Future Improvements
- Add deep validation to the form fields, does not seem .NET 8 supports the ObjectGraphDataAnnotationsValidator yet.
- Add unit testing
- Create shared generic form to be used for Add and Edit operations
- Add paging, filtering and sorting to the employee list
- Update Delete operation to use a modal dialog