using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba12
{
    class Adress
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
        public Adress(string country, string city) 
        {
            Country = country;
            City = city;
            Apartments = new List<Apartment>();
        }
        public Adress() { }
        public override string ToString()
        {
            return "Country = " + Country + " \r\n City = " + City;
        }
    }
}
