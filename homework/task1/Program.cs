using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Program
    {
        //Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
        static void Main(string[] args)
        {
            int numberOne = 23554;
            int numberTwo = 17453;
            int numberThree = 542;

            Console.WriteLine("{0}  {1}  {2}", numberOne, numberTwo, numberThree);

            Console.ReadLine();
        }
    }
}
