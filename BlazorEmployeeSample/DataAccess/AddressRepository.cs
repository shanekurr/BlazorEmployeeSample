using BlazorEmployeeSample.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmployeeSample.DataAccess;

class AddressRepository(IDbContextFactory<EmployeeSampleContext> contextFactory) : IAddressRepository
{
    private readonly EmployeeSampleContext _context = contextFactory.CreateDbContext();
    public async Task<Address?> GetAddressAsync(long id)
    {
        return await _context.Addresses.FirstOrDefaultAsync(t => t.AddressId == id);
    }

    public async Task<Address?> AddAddressAsync(Address address)
    {
        var newAddress = await _context.Addresses.AddAsync(address);
        await _context.SaveChangesAsync();
        return newAddress.Entity;
    }

    public async Task<Address?> UpdateAddressAsync(Address address)
    {
        var result = _context.Addresses.Update(address);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteAddressAsync(Address address)
    {
        var result = _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
        return result.State == EntityState.Deleted;
    }
}