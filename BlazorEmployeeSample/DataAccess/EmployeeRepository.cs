using BlazorEmployeeSample.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmployeeSample.DataAccess;

public class EmployeeRepository(IDbContextFactory<EmployeeSampleContext> contextFactory) : IEmployeeRepository
{
    private readonly EmployeeSampleContext _context = contextFactory.CreateDbContext();

    public async Task<IEnumerable<Employee?>> GetEmployeesAsync()
    {
       return await _context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeAsync(long id)
    {
        return await _context.Employees.Include("Addresses").FirstOrDefaultAsync(t => t.EmployeeId == id);   
    }

    public async Task<Employee?> AddEmployeeAsync(Employee employee)
    {
        var newEmployee = await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
        return newEmployee.Entity;
    }

    public async Task<Employee?> UpdateEmployeeAsync(Employee employee)
    {
        var result = _context.Employees.Update(employee);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteEmployeeAsync(Employee employee)
    {
        var result = _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return result.State == EntityState.Deleted;
    }
}