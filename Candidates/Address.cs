using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class Address
    {
        public int House;
        public int Flat;
        public string Street;
        public string City;

        public Address(int house, int flat, string street, string city)
        {
            House = house;
            Flat = flat;
            Street = street;
            City = city;
        }
    }
}
