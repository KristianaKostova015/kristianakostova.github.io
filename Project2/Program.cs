using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        Console.Write("Въведете път до оригиналния файл: ");
        string inputFile = Console.ReadLine();

        Console.Write("Въведете път за компресирания файл (напр. compressed.gz): ");
        string outputFile = Console.ReadLine();

        try
        {
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            using (GZipStream compressionStream = new GZipStream(outputFileStream, CompressionMode.Compress))
            {
                inputFileStream.CopyTo(compressionStream);
            }

            Console.WriteLine("✅ Файлът е успешно компресиран.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Грешка: {ex.Message}");
        }
    }
}
