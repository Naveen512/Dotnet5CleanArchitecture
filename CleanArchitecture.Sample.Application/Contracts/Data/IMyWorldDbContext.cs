using CleanArchitecture.Sample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Sample.Application.Contracts.Data
{
    public interface IMyWorldDbContext
    {
        public DbSet<Gadgets> Gadgets { get; }
    }
}