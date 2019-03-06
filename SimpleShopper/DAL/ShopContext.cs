using SimpleShopper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShopper.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext():base()
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
