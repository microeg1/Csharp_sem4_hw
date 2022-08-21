using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите введите степень:");
        int deg = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Число " + number + " в " + deg + " степени, равняется " + Math.Pow(number, deg) + ".");
    }
}