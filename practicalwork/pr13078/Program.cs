using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13078
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значений логических выражений. Введите выражения(true/false)");
            Console.Write("X: ");
            bool varX = Boolean.Parse(Console.ReadLine());
            Console.Write("Y: ");
            bool varY = Boolean.Parse(Console.ReadLine());

            bool res1, res2, res3;
            res1 = (!varX && !varY);
            res2 = varX || (!varX && varY);
            res3 = (!varX && varY) || varY;

            Console.WriteLine("!X && !Y = " + res1);
            Console.WriteLine("X || (!X && Y) = " + res2);
            Console.WriteLine("(!X && Y) || Y = " + res3);
            
            Console.ReadLine();
        }
    }
}
