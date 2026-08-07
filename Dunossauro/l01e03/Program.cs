using System;

namespace l01e03
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = 0, m = 0, soma = 0;
            n = Read();
            m = Read();
            soma = n + m;
            Console.WriteLine("A soma de {0} com {1} é {2}.", n, m, soma);
        }

        public static int Read()
        {
            while(true)
            {
                Console.Write("Digite um número: ");
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
            }
        }
    }
}
