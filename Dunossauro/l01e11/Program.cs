using System;

namespace l01e11
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int primeiro = ReadInt("Digite o primeiro número inteiro: ");
            int segundo = ReadInt("Digite o segundo número inteiro: ");
            double terceiro = ReadDouble("Digite um número real: ");

            double produtoDobroMetade = (primeiro * 2) * (segundo / 2.0);
            double somaTriploTerceiro = (primeiro * 3) + terceiro;
            double terceiroCubo = Math.Pow(terceiro, 3);

            Console.WriteLine("Produto do dobro do primeiro com metade do segundo: {0:F2}", produtoDobroMetade);
            Console.WriteLine("Soma do triplo do primeiro com o terceiro: {0:F2}", somaTriploTerceiro);
            Console.WriteLine("Terceiro elevado ao cubo: {0:F2}", terceiroCubo);
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
            }
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
