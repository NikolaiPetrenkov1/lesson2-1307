using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    /*
     * 6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: 
     *      А = Истина, В = Ложь, С = Ложь:	
     *   a.	А или В; 	
     *   b.	А и В; 	
     *   c.	В или С.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            bool result1 = A || B;
            bool result2 = A && B;
            bool result3 = B || C;

            Console.WriteLine("A || B = " + result1);
            Console.WriteLine("A && B = " + result2);
            Console.WriteLine("B || C = " + result3);

            Console.ReadLine();
        }
    }
}
