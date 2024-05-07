using BlazorEmployeeSample.Models;

namespace BlazorEmployeeSample.DataAccess
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee?>> GetEmployeesAsync();
        Task<Employee?> GetEmployeeAsync(long id);
        Task<Employee?> AddEmployeeAsync(Employee employee);
        Task<Employee?> UpdateEmployeeAsync(Employee employee);
    }
}
