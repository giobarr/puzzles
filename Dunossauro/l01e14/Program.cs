using System;

namespace l01e14
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double peso = ReadDouble("Digite o peso dos peixes em quilos: ");
            const double limite = 50.0;
            const double multaPorQuilo = 4.0;

            double excesso = Math.Max(0, peso - limite);
            double multa = excesso * multaPorQuilo;

            Console.WriteLine("Peso informado: {0:F2} kg", peso);
            Console.WriteLine("Excesso de peso: {0:F2} kg", excesso);
            Console.WriteLine("Valor da multa: R$ {0:F2}", multa);
        }

        private static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
            }
        }
    }
}
