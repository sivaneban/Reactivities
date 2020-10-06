using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value{Id =1, Name = "Test_1"},
                    new Value{Id =2, Name = "Test_2"},
                    new Value{Id =3, Name = "Test_3"},
                    new Value{Id =4, Name = "Test_4"},
                    new Value{Id =5, Name = "Test_5"}
                );
        }
    }
}
