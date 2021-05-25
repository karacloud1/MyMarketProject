using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Cloud;Integrated Security=True");
        }

        public DbSet<Product> TblProduct { get; set; }
        public DbSet<Category> TblCategory { get; set; }
        public DbSet<User> TblUser { get; set; }
        public DbSet<Order> TblOrder { get; set; }

    }
}
