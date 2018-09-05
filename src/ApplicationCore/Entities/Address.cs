using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Address
    {
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Address()
        {
        }

        public Address(string address1, string address2, string city, string country, string zipcode)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            Country = country;
            ZipCode = zipcode;
        }
    }
}