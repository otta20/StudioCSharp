using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio4();
            //Esercizio5();
            Esercizio6();
            Console.ReadLine();
        }
        static void Esercizio4()
        {
            Console.WriteLine("### ESERCIZIO 4 ###");
            //Write a program in C# Sharp to print individual characters of the string in reverse order
            Console.WriteLine("INSERISCI LA TUA FRASE:");
            string fraseInserita = Console.ReadLine();

            char[] fraseInversa = new char[fraseInserita.Length];
            int r = 0;
            for (int i = fraseInserita.Length - 1; i >= 0; i--)
            {
                fraseInversa[r] = fraseInserita[i];
                r++;
            }

            string fraseFinale = " ";
            for (r = 0; r < fraseInversa.Length - 1; r++)
            {

                fraseFinale = fraseFinale + fraseInversa[r];
            }
            Console.WriteLine($"{fraseFinale}");
        }

        static void Esercizio5()
        {
            //Write a program in C# Sharp to count the total number of words in a string
            Console.WriteLine("### ESERCIZIO 5 ###");
            Console.WriteLine("Scrivi un programma in C# che conteggi il numero delle parole in una stringa");
            Console.WriteLine("Inserisci la tua frase");
            string fraseInserita = Console.ReadLine();
            char[] caratteriDaEliminare = new char[] { ' ', ',', ';', ':', '!', '?', '^', '=', ')', '(', '/', '%', '£', '"', '|', '\n', '{', '}', '[', ']' };

            string[] fraseDaManipolare = fraseInserita.Split(caratteriDaEliminare, StringSplitOptions.None);

            Console.WriteLine($"La frase che hai inserito {fraseInserita} contiene n.{fraseDaManipolare.Length} stringhe");
        }

        static void Esercizio6()
        {
            Console.WriteLine("Write a program in C# Sharp to compare two string without using string library functions");
            Console.WriteLine("Inserisci la prima frase: ");
            string primaFrase = Console.ReadLine();
            Console.WriteLine("Inserisci la seconda frase: ");
            string secondaFrase = Console.ReadLine();

            char[] caratteriDaEliminare = new char[] { ' ', ',', ';', '.', ':', '[', ']', '{', '}', '(', ')', '/', '\n' };
            string[] parolePrimaFrase = primaFrase.Split(caratteriDaEliminare, StringSplitOptions.None);
            string[] paroleSecondaFrase = secondaFrase.Split(caratteriDaEliminare, StringSplitOptions.None);

            /*  if (parolePrimaFrase.Length == paroleSecondaFrase.Length)
              {
                  for (int p = 0; p < parolePrimaFrase.Length; p++)
                  {
                      currentWord = parolePrimaFrase[p];
                      if (paroleSecondaFrase[s] == currentWord)
                      {
                          s++;
                      }
                      else
                      {
                          Console.WriteLine("Le due frasi inserite hanno la stessa lunghezza ma non sono identiche.");
                      }
                  }
                  Console.WriteLine("Le due frasi hanno la stessa lunghezza e sono composte dalle stesse parole nello stesso ordine");

              }
              else
              {
                  Console.WriteLine("le due frasi inserite non sono uguali");
              }
              */
            if (parolePrimaFrase.Length != paroleSecondaFrase.Length)
            {
                Console.WriteLine("le due frasi inserite non sono uguali");
            }
            else
            {
                bool leFrasiSonoUguali = true;
                for (int p = 0; p < parolePrimaFrase.Length - 1; p++)
                {
                    if (paroleSecondaFrase[p] != parolePrimaFrase[p])
                    {
                        leFrasiSonoUguali = false; 
                        break;
                    }
                }
                if (leFrasiSonoUguali)
                {
                    Console.WriteLine("Le due frasi hanno uguale lunghezza e le loro parole sono disposte nello stesso ordine.");
                }
                else
                {
                    Console.WriteLine("Le due frasi hanno uguale lunghezza , ma le parole al loro interno non corrispondono.");
                }
                
            }
        }
    }
}
}
