using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        //Вывести на экран числа 5, 10 и 21 одно под другим.
        static void Main(string[] args)
        {
            int numOne = 5;
            int numTwo = 10;
            int numThree = 21;

            Console.WriteLine("v1");
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
            Console.WriteLine(numThree);

            Console.WriteLine("\nv2");
            Console.WriteLine(numOne + "\n" + numTwo + "\n" + numThree);

            Console.WriteLine("\nv3");
            Console.WriteLine("{0}\n{1}\n{2}",numOne, numTwo, numThree);

            Console.WriteLine("\nv4");
            int[] array = { 5, 10, 21 };
            foreach (int i in array)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
