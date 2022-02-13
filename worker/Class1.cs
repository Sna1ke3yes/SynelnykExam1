using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worker
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public double Wages;
        public double DaysWorked;

       

        public enum Post
        {
            junior = 30000,
            middle = 60000,
            senior = 90000
        }

        public Employee(string name, string surname, int DaysWorked)
        {
            Name = name;
            Surname = surname;
            this.DaysWorked = DaysWorked;
        }

        public double multiplier(double DaysWorked)

        {
            double a = DaysWorked;

            if (a <= 730)
                return 1;
            else if (a <= 1825)
                return 1.5;
            else
                return 2;
        }
        public double WagesCalc(Post position)

        {
            double grade = multiplier(DaysWorked);

            switch (position)
            {
                case Post.junior:
                    Wages = 30000 * grade;
                    return Wages;
                case Post.middle:
                    Wages = 60000 * grade;
                    return Wages;
                case Post.senior:
                    Wages = 90000 * grade;
                    return Wages;
                default:

                    Console.WriteLine("No such position!");
                    return 0;

                    break;


            }
        }
    }
}
