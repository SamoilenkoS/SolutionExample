using System;

namespace ProjectExample
{
    class Program
    {
        static void Task1()
        {
            //X^2 + 3*X – C
            int X = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            int result = X * X + 3 * X - C;

            Console.WriteLine(result);
        }

        static void Task2()
        {
            Console.Write("Enter kilometers value:");
            int kilometers = Convert.ToInt32(Console.ReadLine());

            int meters = kilometers * 1000;
            Console.WriteLine("Meters amount:" + meters);
        }

        static void Main(string[] args)
        {

            

            //double a = Convert.ToDouble(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);
        }
    }
}
