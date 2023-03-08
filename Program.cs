using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string password = "123";
            int attempts = 3;
            int unit = 1;

            for (int i = 0; i < attempts; i++)
            {
                Console.Write(" Введите пароль ");
                userInput = Console.ReadLine();
               
                if (userInput == password)
                {
                    Console.WriteLine(" Секретный код 564 ");
                    break;
                }
                else
                {
                    Console.WriteLine(" осталось - " + (attempts - i - unit) + " попыток ");
                }
            }  

        }
    }
}
