using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myTuple
{
    class Program
    {
        static void Main(string[] args)
        {
             string facultyNumber = "22251421015";

             int n = (int)(long.Parse(facultyNumber) % 4 + 2);

            Console.WriteLine($"n = {n}");

             char secondLastDigit = facultyNumber[facultyNumber.Length - 2];

            string filePath = "file.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                List<MyTuple> tuples = new List<MyTuple>();

                foreach (var line in lines)
                {
                    var parts = line.Split(',')
                                    .Select(p => p.Trim()) // Trim any spaces
                                    .ToArray();

                    if (parts.Length == n)
                    {
                        int[] values = parts.Select(int.Parse).ToArray();
                        tuples.Add(new MyTuple(values));
                    }
                }

                var filtered = tuples.Where(t =>
                    t.Values[1].ToString().EndsWith(secondLastDigit.ToString())
                );

                 Console.WriteLine("Резултати:");
                foreach (var tuple in filtered)
                {
                    Console.WriteLine(tuple);
                }
            }
            else
            {
                Console.WriteLine("Файлът не е намерен.");
            }
        }
    }
}

