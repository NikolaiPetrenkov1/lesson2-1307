using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13074
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 234;
            Console.WriteLine("Дней: " + days);
            int weeks = days / 7;
            Console.WriteLine("Недель: " + weeks);
            Console.ReadLine();
        }
    }
}
