using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER
{
     class User
    {
        public string Login;
        public string Name;
        public string Surname;
        public int Age;
        private readonly DateTime Registr;
        public DateTime registr
        {
            get { return Registr; }
            set { registr = value; }
        }




        public User(string login, string name, string surname, int age, DateTime registr)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Registr = registr;
        }
    }

}
