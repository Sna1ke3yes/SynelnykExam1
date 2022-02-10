using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класы2
{
    class Adress
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private string country;


        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;


        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;


        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int house;


        public int House
        {
            get { return house; }
            set { house = value; }
        }

        private int apartment;


        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
