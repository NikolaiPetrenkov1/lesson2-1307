using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task9
{
    //Известны сопротивления двух несоединенных друг с другом участков электрической цепи 
    //и напряжение на каждом из них. По какому участку протекает меньший ток?
    class Program
    {
        static double Current(double resistance, double voltage)
        {
            return voltage / resistance;
        }

        static void Main(string[] args)
        {
            double resistance1, voltage1, resistance2, voltage2;

            Console.WriteLine("По какому участку цепи проходит меньший ток?\n");

            Console.WriteLine("Участок 1");
            Console.Write("Сопротивление: ");
            resistance1 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage1 = Double.Parse(Console.ReadLine());

            double elCurrent1 = Current(resistance1, voltage1);
            Console.WriteLine("Ток: " + elCurrent1);

            Console.WriteLine("\nУчасток 2");
            Console.Write("Сопротивление: ");
            resistance2 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage2 = Double.Parse(Console.ReadLine());

            double elCurrent2 = Current(resistance2, voltage2);
            Console.WriteLine("Ток: " + elCurrent2);

            string answer = elCurrent1 < elCurrent2 ? "первому" : "второму";
            Console.WriteLine("\nМеньший ток проходит по {0} участку цепи", answer);

            Console.ReadLine();
        }
    }
}
