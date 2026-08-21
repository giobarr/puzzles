using System;

namespace l01e10
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double celsius = Read("Digite a temperatura em Celsius: ");
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Temperatura em Fahrenheit: {0:F2} °F", fahrenheit);
        }

        public static double Read(string prompt)
        {
            while(true)
            {
                Console.Write(prompt);
                if(double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
