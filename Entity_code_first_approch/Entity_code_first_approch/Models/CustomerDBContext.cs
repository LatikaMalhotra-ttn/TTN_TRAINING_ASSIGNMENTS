//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entity_code_first_approch.Data;

namespace Entity_code_first_approch.Models
{
    public class CustomerDBContext: DbContext
    {

        public CustomerDBContext() : base("name=CustomerConnection")
        {
            //Database.SetInitializer(new CustomerSeeder());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}