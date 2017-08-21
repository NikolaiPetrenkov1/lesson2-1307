using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Program
    {
        //Дано расстояние в сантиметрах. Найти число полных метров в нем.
        static void Main(string[] args)
        {
            Console.WriteLine("Сантиметры в полные метры\n");
            Console.Write("СМ: ");
            int sm = Int32.Parse(Console.ReadLine());
            int m = (int)(sm * .001);
            Console.Write("М: " + m);

            Console.ReadLine();
        }
    }
}
