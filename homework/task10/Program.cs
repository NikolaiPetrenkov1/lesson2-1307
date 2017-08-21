using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task10
{
    /*
     * Напечатать "столбиком": 
     *      a.	все целые числа от 20 до 35; 
     *      b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10); 
     *      c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50); 
     *      d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
     */
    class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 целые числа от 20 до 25");
            Console.WriteLine("2 квадраты всех целых чисел от 10 до b");
            Console.WriteLine("3 третьи степени всех целых чисел от a до 50");
            Console.WriteLine("4 все целые числа от a до b");
            Console.WriteLine("\n0 выход");
        }

        static void Main(string[] args)
        {
            string menu = "#";
            
            while(menu != "0")
            {
                Menu();
                Console.Write("Выберите действие: ");
                menu = Console.ReadLine();

                Console.Clear();
                if(menu == "1")
                {
                    for(int i = 20; i < 25; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }
                else if(menu == "2")
                {
                    Console.Write("Верхняя граница(b>10): ");
                    int number = Int32.Parse(Console.ReadLine());

                    number = number < 10 ? 20 : number;

                    for(int i = 10; i < number; i++)
                    {
                        Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if(menu == "3")
                {
                    Console.Write("Нижняя граница(a<50): ");
                    int number = Int32.Parse(Console.ReadLine());

                    number = number > 50 ? 40 : number;

                    for (int i = number; i < 50; i++)
                    {
                        Console.WriteLine(i + "^3 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if(menu == "4")
                {
                    Console.Write("Нижняя граница: ");
                    int numberA = Int32.Parse(Console.ReadLine());
                    Console.Write("Верхняя граница: ");
                    int numberB = Int32.Parse(Console.ReadLine());

                    if (numberA > numberB)
                    {
                        int tmp = numberB;
                        numberB = numberA;
                        numberA = tmp;
                    }

                    for(;numberA < numberB; numberA++)
                    {
                        Console.WriteLine(numberA);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
