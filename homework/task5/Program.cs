using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task5
{
    class Program
    {
        //Дано двузначное число. Найти:
	    //a.	число десятков в нем;
	    //b.	число единиц в нем;
	    //c.	сумму его цифр;
	    //d.	произведение его цифр
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2хзначное число: ");
            int number = Int32.Parse(Console.ReadLine());
            int dec = number / 10;
            int unt = number % 10;

            int sum = dec + unt;
            int mult = dec * unt;

            Console.WriteLine("Число десятков: " + dec);
            Console.WriteLine("Число единиц: " + unt);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + mult);

            Console.ReadLine();
        }
    }
}
