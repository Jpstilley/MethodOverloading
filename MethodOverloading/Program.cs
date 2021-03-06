using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(14, 16));
            Console.WriteLine(Add(0.5m, 2.25m));
            Console.WriteLine(Add(0, 1, false));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(3, 1, true));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            string plural = (x + y > 1) ? "s" : "";
            return (isTrue) ? $"{x + y} dollar{plural}"
                            : $"We're not allowed to add your numbers";
        }
    }
}
