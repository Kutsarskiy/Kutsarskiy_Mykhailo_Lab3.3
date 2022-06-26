using System;
using System.Collections.Generic;
using System.Linq;


namespace Laba3
{
    public class Task3
    {
        public static void Third()
        {
            int size = 10;
            var listOfNums = new List<int>(size);

            var random = new Random();
            for (int i = 0; i < size; i++) listOfNums.Add(random.Next(-15, 15));

            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            Console.Write($"Целые числа: {string.Join(", ", listOfNums)}");

            var positive = string.Join(", ", listOfNums.Where(n => n > 0));
            Console.WriteLine($"\nПоложительные числа: {positive} ");
            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        }
    }
}
