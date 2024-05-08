using BlazorEmployeeSample.Models;

namespace BlazorEmployeeSample.DataAccess
{
    public interface IAddressRepository
    {
        Task<Address?> GetAddressAsync(long id);
        Task<Address?> AddAddressAsync(Address address);
        Task<Address?> UpdateAddressAsync(Address address);
        Task<bool> DeleteAddressAsync(Address address);
    }
}
