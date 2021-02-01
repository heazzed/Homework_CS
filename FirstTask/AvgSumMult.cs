using System;

namespace FirstTask
{
    class AvgSumMult
    {
        static void Main(string[] args)
        {
            double firstVariable, secondVariable, thirdVariable, avg, sum, mult;

            Console.WriteLine("Введите первое число:");
            firstVariable = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Введите второе число:");
            secondVariable = double.Parse(Console.ReadLine());

            avg = (firstVariable + secondVariable) / 2;

            Console.WriteLine("Среднее арифметическое первых двух введенных чисел равно " + avg);

            Console.WriteLine("Введите третье число:");
            thirdVariable = double.Parse(Console.ReadLine());

            sum = firstVariable + secondVariable + thirdVariable;
            mult = firstVariable * secondVariable * thirdVariable;

            Console.WriteLine("Сумма трех введенных чисел равна " + sum + ",\n" +
                "Произведение этих трех чисел равно " + mult);

            Console.ReadLine();
        }
    }
}
