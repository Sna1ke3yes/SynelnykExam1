using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конвертер
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double USD = 28.13;
            double EUR = 31.93;
            double RUB = 2.67;
            
            Converter Curs = new Converter(USD, EUR, RUB);
        }
    }
}
