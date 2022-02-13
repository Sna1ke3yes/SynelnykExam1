using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конвертер
{
   class Converter
    {
        double USD;

        double EUR;

        double RUB;

       


        public Converter(double USD, double EUR, double RUB)
        {
            this.USD = USD;

            this.EUR = EUR;

            this.RUB = RUB;

         


            Console.WriteLine("Если хотите обменять с гривен на другие валюты(введите +) ,а если с других валют на гривны(введите -): ");
            string b = Console.ReadLine();
            if (b == "+")
            {


                Console.Write("Введите сколько гривен вы хотите перевести: ");
                double con = Convert.ToDouble(Console.ReadLine());

                double result = con;
                Console.Write("Выберите валюту в которую хотите перевести 1 -доллары,2 -евро,3 -руб: ");
                string choise = Console.ReadLine();

                if (choise == "1")
                {
                    result = con / USD;
                    Console.WriteLine($"долар:{result}");
                }
               

                else if (choise == "2")
                {
                    result = con / EUR;
                    Console.WriteLine($"евро:{result}");
                }

                else if (choise == "3")
                {
                    result = con / RUB;
                    Console.WriteLine($"рубли:{result}");
                }
                else

                    Console.WriteLine("ОШИБКА");
            }
            else if (b == "-")
            {
                Console.Write("Введите сколько валюты вы хотите перевести: ");
                double con = Convert.ToDouble(Console.ReadLine());

                double result = con;
                Console.Write("что это за валюта 1 -руб,2 -евро,3 -доллары: ");
                string choise = Console.ReadLine();

                if (choise == "1")
                {
                    result = con * RUB;
                    Console.WriteLine($"гривны:{result}");
                }

                else if (choise == "2")
                {
                    result = con * EUR;
                    Console.WriteLine($"гривны:{result}");
                }

                else if (choise == "3")
                {
                    result = con * USD;
                    Console.WriteLine($"гривны:{result}");
                }
                else

                    Console.WriteLine("ОШИБКА");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }


            Console.ReadKey();

        }


      
}
}
