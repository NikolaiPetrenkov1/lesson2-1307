using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13076
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4хзначное число: ");
            int number = Int32.Parse(Console.ReadLine());

            int halfOne = number / 100;
            int halfSnd = number % 100;

            int thnd = halfOne / 10;
            int hund = halfOne % 10;
            int dec = halfSnd / 10;
            int unt = halfSnd % 10;

            int sum = thnd + hund + dec + unt;
            int mult = thnd * hund * dec * unt;
            
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + mult);

            Console.ReadLine();
        }
    }
}
