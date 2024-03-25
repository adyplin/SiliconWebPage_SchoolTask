using Infrasctructure.Contexts;
using Infrasctructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrasctructure.Services;

public class AddressManager(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    #region GetAddress

    public async Task<AddressEntity> GetAddressAsync(string UserId)
    {
        var addressEntity = await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == UserId);
        return addressEntity!;
    }
    #endregion

    #region CreateAddress
    public async Task<bool> CreateAddressAsync(AddressEntity entity)
    {
        _context.Addresses.Add(entity);
        await _context.SaveChangesAsync();
        return true;
    }
    #endregion

    #region UpdateAddress
    public async Task<bool> UpdateAddressAsync(AddressEntity entity)
    {
        var existing = await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == entity.UserId);
        if (existing != null)
        {
            _context.Entry(existing).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        return false;
    }
    #endregion
}
