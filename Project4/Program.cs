using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Добре дошли във Валутен Конвертор!");

        Console.Write("Въведи сума: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount < 0)
        {
            Console.WriteLine("Невалидна сума.");
            return;
        }

        Console.Write("Избери валута (EUR, USD, GBP): ");
        string currency = Console.ReadLine().ToUpper();

        Console.Write("Избери посока (toBGN / fromBGN): ");
        string direction = Console.ReadLine().ToLower();

        decimal rate = currency switch
        {
            "EUR" => 1.95583m,
            "USD" => 1.80m,
            "GBP" => 2.30m,
            _ => 0
        };

        if (rate == 0)
        {
            Console.WriteLine("Невалидна валута.");
            return;
        }

        decimal result = 0;

        if (direction == "tobgn")
        {
            result = amount * rate;
            Console.WriteLine($"{amount} {currency} = {result:F2} BGN");
        }
        else if (direction == "frombgn")
        {
            result = amount / rate;
            Console.WriteLine($"{amount} BGN = {result:F2} {currency}");
        }
        else
        {
            Console.WriteLine("Невалидна посока.");
        }
    }
}
