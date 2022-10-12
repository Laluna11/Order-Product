using System;
using System.Collections.Generic;

namespace Zanobya.Data
{
    public class Customers
    {
        public int CustomersId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public ICollection<Orders> Orders { get; set; }

       
    }
}
