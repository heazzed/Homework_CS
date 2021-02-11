using System;

namespace FirstTaskConverter
{
    class Converter
    {
        static void Main(string[] args)
        {
            double valueInRubles, valueInDollars, valueInEuro;

            Console.WriteLine("Введите сумму в рублях:");
            valueInRubles = double.Parse(Console.ReadLine());

            valueInDollars = valueInRubles * 0.01325;
            valueInEuro = valueInRubles * 0.01085;

            Console.WriteLine("Сумма в долларах равна " + valueInDollars + "\n" +
                "Сумма в евро равна " + valueInEuro);

            Console.ReadLine(); 
        }
    }
}
