using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Введенное число четное");
            }
            else
            {
                Console.WriteLine("Введенное число нечетное");
            }
        }
    }
}
