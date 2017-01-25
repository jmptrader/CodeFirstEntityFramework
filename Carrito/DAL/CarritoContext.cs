using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Carrito.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Carrito.DAL
{
    public class CarritoContext:DbContext
    {
        public CarritoContext():base("CarritoContext") { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}