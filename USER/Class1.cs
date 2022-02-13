using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER
{
    internal class Class1
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private DateTime registr ;


        public string Name { get; set; }
        public string login { get; set;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime registr { get; set; }

        public User(string login, string name, string surname, int age, DateTime regisr)
            {
                Login = login;
                Name = name;
                Surname = surname;
                Age = age;
                Regisr = regisr;
            }
             public string Name { get; set; }
                public string Surname { get; set; }
                public DateTime DateOfHire
                {
                    get
                    {
                        return dateOfHire;
                    }
                    set
                    {
                        if (dateOfHire.Date < DateTime.Parse("01.01.1995"))
                        {
                            dateOfHire = value;
                        }
                        else
                        {
                            Console.WriteLine("Date before times!");
                        }
                
                    }


                }
    }
