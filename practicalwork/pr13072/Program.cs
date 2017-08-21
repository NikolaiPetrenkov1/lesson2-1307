using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13072
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");

            double radius = Double.Parse(Console.ReadLine());
            double pi = 3.1415;

            double lengthCircle = 2 * pi * 3;
            double areaCircle = pi * radius * radius;

            Console.WriteLine("Длина окружности: " + lengthCircle);
            Console.WriteLine("Площадь круга: " + areaCircle);

            Console.ReadLine();
        }
    }
}
