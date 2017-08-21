using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13077
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 456;
            Console.WriteLine("Исходное исло: " + number);

            int hund = number / 100;
            int half = number / 10;
            int dec = half % 10;
            int unt = number % 10;

            Console.WriteLine("Число: " + hund + unt + dec);

            Console.ReadLine();
        }
    }
}

