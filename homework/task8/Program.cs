using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task8
{
    //Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
    class Program
    {
        static double Density(double mass, double volume)
        {
            return mass / volume;
        }

        static void Main(string[] args)
        {
            double volume1, mass1, volume2, mass2;

            Console.WriteLine("У какого материала бОльшая плотность?\n");

            Console.WriteLine("Материал 1");
            Console.Write("Объем: ");
            volume1 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass1= Double.Parse(Console.ReadLine());

            double density1 = Density(mass1, volume1);
            Console.WriteLine("Плотность: " + density1);

            Console.WriteLine("\nМатериал 2");
            Console.Write("Объем: ");
            volume2 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass2 = Double.Parse(Console.ReadLine());

            double density2 = Density(mass2, volume2);
            Console.WriteLine("Плотность: " + density2);

            string answer = density1 > density2 ? "первого" : "второго";
            Console.WriteLine("\nНаибольшая плотность у {0} материала", answer);

            Console.ReadLine();
        }
    }
}
