using DAL.Models;
using DAL.Models.Login;
using DAL.Models.SignUp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class SwiftSaleContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Seller> Sellers { get; set; }   
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get;set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

    }
}
