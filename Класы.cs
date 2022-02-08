using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класы2
{
    class Adress
    {
        private string index;

        public string Index
        {
            get { return Index; }
            set { Index = value; }
        }
        private string country;


        public string Country
        {
            get { return Country; }
            set { Country = value; }
        }

        private string city;


        public string City
        {
            get { return City; }
            set { City = value; }
        }

        private string street;


        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;


        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;


        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Adress a = new Adress();
            a.Index = "02125";
            a.Country = "Ukraine";
            a.City = "Kyiv";
            a.Street = "Green";
            a.House = "9";
            a.Apartment = "34";

                Console.Write($" Index: {a.Index} " +
                    $" Country: {a.Country} " +
                    $" City: {a.City} " +
                    $" Street: {a.Street} " +
                    $" House: {a.House}" +
                    $" Apartment: {a.Apartment}");



        }
    }
}
