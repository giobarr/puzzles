using System;

namespace l01e13
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double gigabytes = ReadDouble("Digite a quantidade de Gigabytes: ");
            double megabytes = gigabytes * 1024;
            double kilobytes = gigabytes * 1024 * 1024;

            Console.WriteLine("Equivalente em Megabytes: {0:F2}", megabytes);
            Console.WriteLine("Equivalente em Kilobytes: {0:F2}", kilobytes);
        }

        private static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
