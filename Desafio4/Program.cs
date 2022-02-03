using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int esferas;
            int procurar;
            for (int i = 0; i < numero; i++)
            {
                procurar = 0;
                esferas = int.Parse(Console.ReadLine());
                for (int j = 1; j <= esferas; j++)
                {
                    if((divisores(j)%2) == 0)
                    {
                        procurar++;
                    }
                }
                Console.WriteLine(procurar);
            }
                
        }

        private static int divisores(int dividendo)
        {
            int divisores = 0;
            for(int i = 1; i <= dividendo; i++)
            {
                if((dividendo%i) == 0)
                {
                    divisores++;
                }
            }
            return divisores;
        }
    }
}
