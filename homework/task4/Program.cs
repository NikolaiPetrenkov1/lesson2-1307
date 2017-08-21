using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Program
    {
        //С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        static void Main(string[] args)
        {
            const int daysInWeek = 7;
            int days = 234;
            int weeks = days / daysInWeek;

            Console.WriteLine("дней: {0}\nнедель: {1}", days, weeks);

            Console.ReadLine();
        }
    }
}
