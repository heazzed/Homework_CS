using System;

namespace FourthTask
{
    class EvenAndOddInRange
    {
        static void Main(string[] args)
        {
            int start, end;
            int sumOdd = 0, sumEven = 0;
            uint amountOdd=0, amountEven=0;

            Console.WriteLine("Введите начало диапазона");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона");
            end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i%2==0)
                {
                    amountEven++;
                    sumEven += i;
                }
                else
                {
                    amountOdd++;
                    sumOdd += i;
                }
            }

            Console.WriteLine("Нечетные числа -> " + "Количество = " + amountOdd + ", Сумма = " + sumOdd
                + "\nЧетные числа -> " + "Количество = " + amountEven + ", Сумма = " + sumEven);
            Console.ReadLine();
        }
    }
}
