using Microsoft.EntityFrameworkCore;
using Didar.Application.Interfaces;
using System.Reflection;


namespace Didar.Infrastructure.Persistance;

public class ApplicationDatabaseContext : DbContext , IApplicationDatabaseContext
{

    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Apply entity configurations from the current assembly
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
