using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabili
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. dichiarazione: dichiarare il tipo e il nome
            int unNumero;
            // 2. assegnamento: impostazione di un valore ad una variabile precedentemente dichiarata
            unNumero = 100;
            // In alternativa, la prassi più comune è di unire subito le due fasi in fase di dichiarazione
            // Questa unione si chiama "definizione"
            int altroNumero = 200;


            //definizione(assegnamento) di una variabile intera
            int età = 30;
            
            //definizione di due varabili intere e loro somma 
            int add1 = 10;
            int add2 = 25;
            int sum = add1 + add2;
            Console.WriteLine("La somma degli addendi è {0}", sum);

            //utilizzo del cast per fare una divsione non intera
            double divisione = ((double)add1 / (double)add2 ) * 2;
            Console.WriteLine("La divione dei dividendi è {0}", divisione);

            //untlizzo della class Math per il calcolo della radice quadrata
            double numero = 256;
            Console.WriteLine("radice quadra di {0} è: {1}",numero, Math.Sqrt(numero));
         
            //esempio di cast con perdita della precisione
            double pippo = 3.14;
            Console.WriteLine("stampa la variabile pippo = {0}", (int)pippo);

            Console.ReadLine();

        }

    }
}
