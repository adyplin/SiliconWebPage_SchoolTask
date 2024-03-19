using Infrasctructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrasctructure.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<UserEntity>(options)
{
    public DbSet<AddressEntity> Addresses { get; set; }
}
