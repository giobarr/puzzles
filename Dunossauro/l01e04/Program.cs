using System;

namespace l01ex04
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, média = 0;
            n1 = Read();
            n2 = Read();
            n3 = Read();
            n4 = Read();
            média = (n1 + n2 + n3 + n4) / 4.0;
            Console.WriteLine(
                "n1: {0}" + Environment.NewLine + 
                "n2: {1}" + Environment.NewLine + 
                "n3: {2}" + Environment.NewLine + 
                "n4: {3}" + Environment.NewLine + 
                "média: {4}", n1, n2, n3, n4, média);
        }
    
        public static double Read()
        {
            while(true)
            {
                Console.Write("Digite uma nota: ");
                if(double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
            }
        }
    }
}