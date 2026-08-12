using System;

namespace l01ex06
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double raio = Read();
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Área do círculo: {0}", area);
        }

        public static double Read()
        {
            while(true)
            {
                Console.Write("Digite o raio do círculo: ");
                if(double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
