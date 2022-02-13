using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User one = new User("Killer", "Daniil", "Synelnyk", 18, DateTime.Now);
            Console.WriteLine($"Login: {one.Login}, Name: {one.Name}, Surname: {one.Surname},Age: {one.Age}, Reristration: {one.registr} ");
            Console.ReadKey();
        }
       
    }
}
