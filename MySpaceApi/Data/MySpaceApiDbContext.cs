using Microsoft.EntityFrameworkCore;
using MySpaceApi.Model;
using MySpaceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySpaceApi.Data
{
    public class MySpaceApiDbContext : DbContext
    {
        public DbSet<Section> Section { get; set; }
        public DbSet<Note> Note { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=MySpaceApiDb;Integrated Security=True;");
        }
    }
}
