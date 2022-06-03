using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public Address(string country, string city, string street, string houseNumber, string postalCode)
        {
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }

        public Address() { }

        public override string ToString()
        {
            return $"{Country}, {City}, {Street} street N{HouseNumber}, {PostalCode}";
        }
    }
}
