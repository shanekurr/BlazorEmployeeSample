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

