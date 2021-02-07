using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value() {Id = 1, Name = "Test 1"},
                new Value() {Id = 2, Name = "Test 2"},
                new Value() {Id = 3, Name = "Test 3"},
                new Value() {Id = 4, Name = "Test 4"},
                new Value() {Id = 5, Name = "Test 5"},
                new Value() {Id = 6, Name = "Test 6"}
            );
        }

        public DbSet<Value> Values { get; set; }     
    }
}