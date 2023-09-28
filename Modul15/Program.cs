using System;
using System.Collections.Generic;
using System.Linq;



class Program
{

    static void Main(string[] args)
    {
        var numList = new List<double>();

        while (true)
        {
            Console.WriteLine("Введите число");
            bool rightNum = double.TryParse(Console.ReadLine(), out double num);

            if (!rightNum)
                Console.WriteLine("Ошибка ввода, введите число");
            else
            {
                numList.Add(num);

                Console.WriteLine($"Количество чисел в списке: {numList.Count}");
                Console.WriteLine($"Сумма чисел в списке: {numList.Sum()}");
                Console.WriteLine($"Наибольшее число в списке: {numList.Max()}");
                Console.WriteLine($"Наименьшее число в списке: {numList.Min()}");
                Console.WriteLine($"Среднее значение чисел в списке: {numList.Average()}");

            }
        }
    }

}

