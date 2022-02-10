using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класы2
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Adress a = new Adress();
            a.Index = 02125;
            a.Country = "Ukraine";
            a.City = "Kyiv";
            a.Street = "Green";
            a.House = 9;
            a.Apartment = 34;

                Console.Write($" Index: {a.Index} " +
                    $" Country: {a.Country} " +
                    $" City: {a.City} " +
                    $" Street: {a.Street} " +
                    $" House: {a.House}" +
                    $" Apartment: {a.Apartment}");



        }
    }
}
