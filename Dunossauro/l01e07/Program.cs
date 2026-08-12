using System;

namespace l01e07
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double lado = Read();
            double area = Math.Pow(lado, 2);
            double dobroArea = area * 2;
            Console.WriteLine("Área do quadrado: {0}", area);
            Console.WriteLine("Dobro da área do quadrado: {0}", dobroArea);
        }

        public static double Read()
        {
            while(true)
            {
                Console.Write("Digite o valor do lado do quadrado: ");
                if(double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}
