using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Въведи положителни цели числа. За край въведи 0.");

        while (true)
        {
            Console.Write("Въведи число: ");
            if (!int.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.WriteLine("Моля, въведи ПОЛОЖИТЕЛНО цяло число или 0 за край.");
                continue;
            }

            if (input == 0)
                break;

            numbers.Add(input);
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"\nРезултати:");
            Console.WriteLine($"Въведени числа: {numbers.Count}");
            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine($"Средно аритметично: {average:F2}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
        else
        {
            Console.WriteLine("❗ Не бяха въведени числа.");
        }
    }
}
