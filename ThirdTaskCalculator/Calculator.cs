using System;

namespace ThirdTaskCalculator
{
    class Calculator
    {
        static double result;
        static void Main(string[] args)
        {

            while (true)
            {
                string action;
                double firstVar, secondVar;

                /*
                using System.Globalization;
                IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                ^
                This making "." separator between whole and fractional parts of number
                 */

                Console.Clear();

                try
                {
                    Console.WriteLine("Введите первое число:");
                    firstVar = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действие (+,-,*,/,%,**)");
                    action = Console.ReadLine();

                    Console.WriteLine("Введите второе число:");
                    secondVar = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                switch (action)
                {
                    case "+":
                        result = firstVar + secondVar;
                        break;
                    case "-":
                        result = firstVar - secondVar;
                        break;
                    case "*":
                        result = firstVar * secondVar;
                        break;
                    case "/":
                        if (secondVar == 0)
                        {
                            Console.WriteLine("Невозможно делить на 0");
                            result = 0;
                        }
                        else
                        {
                            result = firstVar / secondVar;
                        }
                        break;
                    case "%":
                        result = firstVar % secondVar;
                        break;
                    case "**":
                        result = Math.Pow(firstVar, secondVar);
                        break;
                    default:
                        Console.WriteLine("Введено неверное действие");
                        break;
                }
                Console.WriteLine("Результат " + result);
                Console.ReadLine();
            }
        }
    }
}
