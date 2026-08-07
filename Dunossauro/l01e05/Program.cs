using System;

namespace l01e05
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double mt = 0.0, ct = 0.0;
            mt = Read();
            ct = mt * 100.0;
            Console.WriteLine("{0} metros é igual a {1} centímetros.", mt, ct);
        }

        public static double Read()
        {
            while(true)
            {
                Console.Write("Digite um valor em metros: ");
                if(double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
