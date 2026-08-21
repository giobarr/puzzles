using System;

namespace l01e08
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double valorDaHora = Read("Digite o valor da hora trabalhada: ");
            double horasTrabalhadas = Read("Digite a quantia de horas de trabalhadas: ");
            double salario = valorDaHora * horasTrabalhadas;
            Console.WriteLine("Salário: R$ {0:F2}", salario);
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
