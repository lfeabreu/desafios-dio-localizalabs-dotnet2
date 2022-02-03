using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args) {
            string joia = "";
            bool fim = false;
            List<string> joias = new List<string>();
            while (!fim)
            {
                joia = Console.ReadLine();
                fim = string.IsNullOrWhiteSpace(joia);
                if (!fim) {
                    joias.Add(joia);
                }
            }

            IEnumerable<string> distinctJoias = joias.Distinct();
            Console.WriteLine(distinctJoias.Count());
        }
    }
}
