using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee($"Никита", "Гагауз", 610);
            Console.WriteLine($"Name is {worker.Name}, surname is {worker.Surname}. DaysWorked: {worker.DaysWorked}");
            double wages = worker.WagesCalc(Employee.Post.junior);
            Console.WriteLine($"Wages is {wages}, tax is {wages * 0.18}, post is {Employee.Post.junior}.");
            Console.ReadKey();
        }
    }
}
