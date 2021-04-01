using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант задания №4
            double A, B, C, D, Y;
            Console.Write("Введите переменную A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите переменную B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Введите переменную C: ");
            C = double.Parse(Console.ReadLine());
            Console.Write("Введите переменную D: ");
            D = double.Parse(Console.ReadLine());
            Y = (Math.Pow(Math.Sin(C), 3) * Math.Pow(Math.Cos(A), 2)) / (5 * (Math.Pow(Math.Sin(B), D)));
            Console.WriteLine($"Результат: {Y}");
        }
    }
}
