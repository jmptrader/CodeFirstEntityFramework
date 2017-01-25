using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrito.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}