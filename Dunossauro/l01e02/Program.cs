using System;

namespace l01e02
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = 0;
            while(true)
            {
                Console.Write("Digite um número: ");
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    n = result;
                    break;
                }
            }
            Console.WriteLine("O número informado foi {0}.", n);
        }
    }
}