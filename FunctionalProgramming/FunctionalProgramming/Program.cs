using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sum(1, 2);
        }


        /// <summary>
        /// Pura
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int Sum(int a, int b)
        {
            a = a+b;
            return a + b;
        }

        /// <summary>
        /// No Pura (efectos colaterales)
        /// </summary>
        /// <returns></returns>
        private DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        private int GetSum(Func<int> Multi)
        {
            return Multi;
        }
    }
}
