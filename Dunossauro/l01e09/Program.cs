using System;

namespace l01e09
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double fahrenheit = Read("Digite a temperatura em Fahrenheit: ");
            double celsius = (fahrenheit - 32) * 5  / 9;
            Console.WriteLine("Temperatura em Celsius: {0:F2} °C", celsius);
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
