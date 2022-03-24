using System;
using System.Linq;

namespace LINQDemoApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //double average = numbers.Take(6).Average();
            //double average = numbers.Skip(3).Average();
            double average = numbers.Skip(3).Take(2).Average();

            var above = from n in numbers where n > average select n;

            var aboveX = numbers.Where(v => v > average);
            foreach (int n in aboveX)
            {
                Console.WriteLine(n.ToString());
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            int[] num1 = new int[] { 2, 5, 8, 3, 5 };
            int[] num2 = new int[] { 9, 1, 2, 7, 3 };

            //var combine = num1.Concat(num2);

            //var combine = num1.Union(num2);

            var combine = num1.Intersect(num2);

            foreach (int i in combine)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[] num1 = new int[] { 2, 10, 8, 3, 0 };

            Console.WriteLine("Is Contains 2? -> "+ num1.Contains(2));
            Console.WriteLine("Is Contains 8? -> " + num1.Contains(8));
            Console.WriteLine("Is Contains 5? -> " + num1.Contains(5));
            Console.WriteLine("Is any value divisible by 5 ? -> " + num1.Any(x => x % 5 == 0));
            //Console.WriteLine("Is any value divisible by 5 ? -> " + num1.Contains() && num1.Any(x => x % 5 == 0));
            Console.ReadKey();
        }
    }
}
