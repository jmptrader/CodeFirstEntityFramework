using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrito.Models
{
    public class Address
    {
        public Address() { }
        public int ID { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string InternalNumber { get; set; }
        public string ZipCode { get; set; }
        public string Location { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }

        public Customer Customer { get; set; }
    }
}