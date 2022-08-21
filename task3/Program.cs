using System;


class Program
{
    static void PrintArray(int[] col)             // печатает список
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}
    static void Main(string[] args)
    {
        Console.WriteLine("Введите желаемое количество элементов в массиве:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        int index = 0;
        while (index < n)
        {
            numbers[index] = new Random().Next();
            index++;
            
        }
    PrintArray(numbers);
        
        


    }
}