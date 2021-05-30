using CleanArchitecture.Sample.Application.Contracts.Data;
using CleanArchitecture.Sample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Sample.Infrastructure.Data
{
    public class MyWorldDbContext : DbContext, IMyWorldDbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Gadgets> Gadgets { get; set; }
    }
}