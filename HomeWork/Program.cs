using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    static class MyExtension
    {
        public static void Print(this string str)
        {
            int i = 0;
            foreach (char ch in str)
            {
                i++;
            }
            Console.WriteLine($"В строке str {i} символов");
            Console.ReadKey();
        }
    }

    class HomeWork_5
    {

        static void Main(string[] args)
        {
            string str = "Реализовать метод расширения для поиска количество символов в строке";
            List<int> _list = new List<int>();
            _list.AddRange(new int[] { 1, 2, 3, 3, 4, 5 });
            foreach (int i in _list.Distinct())
            {
                Console.WriteLine(i + " - " + _list.Where(x => x == i).Count() + " раз");
            }
            Console.ReadKey();
            str.Print();
        }
    }
}
