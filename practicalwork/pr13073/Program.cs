using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr13073
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние в сантиметрах: ");
            double smetres = Double.Parse(Console.ReadLine());

            double metres = smetres * .001;

            Console.WriteLine("Расстояние в метрах: " + metres);

            Console.ReadLine();
        }
    }
}
