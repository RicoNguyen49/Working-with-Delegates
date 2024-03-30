using System;

namespace Assignment8ex2
{
    // Custom delegate declaration
    public delegate void SmallerDelegate(double a, double b);
    public delegate double ProductDelegate(double a, double b);

    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            // Using Action delegate
            Action<double, double> actionDel = answer.GetSmaller;
            actionDel(num1, num2);

            // Using Func delegate
            Func<double, double, double> funcDel = answer.GetSum;
            Console.WriteLine($" {num1} + {num2} = {funcDel(num1, num2)}");

            // Using custom delegate
            ProductDelegate productDelegate = answer.GetProduct;
            Console.WriteLine($" {num1} * {num2} = {productDelegate(num1, num2)}");
        }
    }
}
