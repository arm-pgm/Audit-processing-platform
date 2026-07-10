using Audit.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Audit.Api.Data;

public class AuditDbContext : DbContext
{
    public AuditDbContext(DbContextOptions<AuditDbContext> options)
        : base(options)
    {
    }

    public DbSet<Job> Jobs => Set<Job>();
}