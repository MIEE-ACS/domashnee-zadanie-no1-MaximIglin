using System;

namespace domashnee_zadanie_no1_MaximIglin
{
    class Program
    {
        static void Main(string[] args)
        {
            get_result_of_function();
        }
        public static void get_result_of_function()
        {
            double y = 0;
            while (y==0){
                try
                {
                    Console.WriteLine("Введите значение переменной x");
                    double x = double.Parse(Console.ReadLine());
                    y = 3 * (Math.Pow(x, 6)) - 6 * (Math.Pow(x, 2)) - 7;
                    Console.WriteLine($"Значение функции y = 3*x^6 - 6*x^2 - 7 при x = {x}: {y}");
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Введите число!");
                }
            }
        }
    }
}
