using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleani
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND logico
            int numero1 = 35;
            int numero2 = 60;
            bool risultato1 = numero1 == 35;
            bool risultato2 = numero2 > 50;
            Console.WriteLine("stampa il risultato dell'AND logico {0}", risultato1 && risultato2);

            risultato1 = numero1 > 0;
            risultato2 = numero2 < 50;
            Console.WriteLine("stampa il risultato dell'AND logico {0}", risultato1 && risultato2);

            //OR logico
            risultato1 = numero1 < 35;
            risultato2 = numero2 < 50;
            Console.WriteLine("stampa il risultato dell'OR logico {0}", risultato1 || risultato2);

            Console.ReadLine();
        }
    }
}
