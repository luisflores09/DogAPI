using Microsoft.EntityFrameworkCore;
using DogAPI.Models;

namespace DogAPI.Data
{
    public class DogDbContext : DbContext
    {
        public DogDbContext(DbContextOptions<DogDbContext> options) : base(options) { }

        public DbSet<Dog> Dogs { get; set; }
    }
}