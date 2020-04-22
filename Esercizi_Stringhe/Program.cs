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
            //Esercizio6();
            //Esercizio1();
            //Esercizio2();
            //Esercizio3();
            //Esercizio7();
            //Esercizio8();
            //Esercizio9();
            //Esercizio12();
            //Esercizio13();
            //Esercizio14();
            //Esercizio14Bis();
            //Esercizio15();

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

        /*static void Esercizio5()
{
    //Write a program in C# Sharp to count the total number of words in a string
    Console.WriteLine("### ESERC
IZIO 5 ###");
    Console.WriteLine("Scrivi un programma in C# che conteggi il numero delle parole in una stringa");
    Console.WriteLine("Inserisci la tua frase");
    string fraseInserita = Console.ReadLine();
    char[] caratteriDaEliminare = new char[] { ' ', ',', ';', ':', '!', '?', '^', '=', ')', '(', '/', '%', '£', '"', '|', '\n', '{', '}', '[', ']' };

    string[] fraseDaManipolare = fraseInserita.Split(caratteriDaEliminare, StringSplitOptions.None);

    Console.WriteLine($"La frase che hai inserito {fraseInserita} contiene n.{fraseDaManipolare.Length} stringhe");
}*/

        /*static void Esercizio6()
        {
            Console.WriteLine("Write a program in C# Sharp to compare two string without using string library functions");
            Console.WriteLine("Inserisci la prima frase: ");
            string primaFrase = Console.ReadLine();
            Console.WriteLine("Inserisci la seconda frase: ");
            string secondaFrase = Console.ReadLine();

            char[] caratteriDaEliminare = new char[] {' '};
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
        /*if (parolePrimaFrase.Length != paroleSecondaFrase.Length)
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
    }*/

        static void Esercizio1()
        {
            //Write a program in C# Sharp to store elements in an array and print it
            Console.WriteLine("### ESERCIZIO 1 ###");
            int[] dieciPosizioni = new int[10];
            int d;

            Console.WriteLine("Inserisci qui i numeri dell'array: ");
            for (d = 0; d < 10; d++)
            {
                Console.Write($"numero - {d}: ");
                dieciPosizioni[d] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Questa è la stampa degli elementi inseriti nell'array");
            for (d = 0; d < 10; d++)
            {
                Console.Write($"{dieciPosizioni[d]}");
            }

        }

        static void Esercizio2()
        {
            //Write a program in C# Sharp to read n number of values in an array and display it in reverse order
            Console.WriteLine("Esercizio 2");
            int[] elencoInserito = new int[5];
            Console.WriteLine($"inserisci qui gli elementi dell'array:");
            for (int e = 0; e < 5; e++)
            {
                Console.Write($"elemento - {e}: ");
                elencoInserito[e] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"questi gli elementi dell'array in ordine inverso:");
            for (int e = 4; e >= 0; e--)
            {
                Console.Write($"{elencoInserito[e]} ");
            }
        }

        static void Esercizio3()
        {
            Console.WriteLine("Write a program in C# Sharp to find the sum of all elements of the array.");
            int sum = 0;
            Console.Write($"inserisci il numenro degli elementi del tuo array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] elencoInserito = new int[n];
            for (int e = 0; e <= n - 1; e++)
            {
                Console.Write($"elemento {e}: ");
                elencoInserito[e] = Convert.ToInt32(Console.ReadLine());
                sum = sum + elencoInserito[e];
            }
            Console.WriteLine($"La somma degli elementi inseriti è: {sum}");

        }

        static void Esercizio5()
        {
            Console.WriteLine("Write a program in C# Sharp to count a total number of duplicate elements in an array.");
            Console.WriteLine("inserisci l'indice del tuo array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int conteggioNumeriDuplicati = 0;
            int[] elencoNumeri = new int[n];
            int[] elencoCopiato = new int[n];

            Console.WriteLine("Inserisci gli elementi del tuo array: ");
            for (int e = 0; e <= n - 1; e++)
            {
                Console.Write($"elemento {e}: ");
                elencoNumeri[e] = Convert.ToInt32(Console.ReadLine());
            }
            for (int e = 0; e <= n - 1; e++)
            {
                for (int d = e + 1; d <= n - 1; d++)
                {
                    if (elencoNumeri[e] == elencoNumeri[d])
                    {
                        conteggioNumeriDuplicati++;
                    }
                }
            }
            Console.WriteLine($"l'elenco inserito contiene n.{conteggioNumeriDuplicati} numeri uguali");
        }

        static void Esercizio6()
        {
            Console.WriteLine("Write a program in C# Sharp to print all unique elements in an array");
            Console.WriteLine("Inserisci la grandezza dell'array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] elencoNumeriInseriti = new int[n];
            Console.WriteLine("inserisci gli elementi dell'array: ");
            for (int e = 0; e <= n - 1; e++)
            {
                Console.Write($"elemento - {e}: ");
                elencoNumeriInseriti[e] = Convert.ToInt32(Console.ReadLine());
            }
            int u = 0;
            int[] elencoNumeriUnici = new int[u];
            for (int e = 0; e <= n - 1; e++)
            {
                for (int d = e + 1; d <= n - 1; d++)
                {
                    if (elencoNumeriInseriti[e] != elencoNumeriInseriti[d])
                    {
                        u++;
                    }
                }
            }
            Console.WriteLine($"ci sono n.{u} numeri unici e sono questi");

        }

        static void Esercizio7()
        {
            Console.WriteLine("Write a program in C# Sharp to count a total number of alphabets, digits and special characters");
            Console.WriteLine("Scrivi qui la tua frase: ");
            string fraseInserita = Console.ReadLine();
            char[] elencoNumeri = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] elencoLettere = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'y', 'x', 'z', 'è', 'é', 'ì', 'ò', 'à', 'ù' };
            char[] caratteriSpeciali = new char[] { '@', '§', '#', '£', '$', '&' };


            int conteggioNumeri = 0;
            int conteggioLettere = 0;
            int conteggioSpeciali = 0;
            for (int c = 0; c <= fraseInserita.Length - 1; c++)
            {
                if (fraseInserita[c] >= '0' && fraseInserita[c] <= '9')
                {
                    conteggioNumeri++;
                }
                else if (fraseInserita[c] >= 'a' && fraseInserita[c] <= 'ù')
                {
                    conteggioLettere++;
                }
                else
                {
                    conteggioSpeciali++;
                }
            }
            Console.WriteLine($"nella frase che hai inserito {fraseInserita} ci sono n.{conteggioNumeri} numeri, n.{conteggioLettere} lettere e n.{conteggioSpeciali} caratteri speciali.");

        }

        static void Esercizio8()
        {
            Console.WriteLine("Esercizio 8: Write a program in C# Sharp to copy one string to another string");
            Console.WriteLine("Inserisci qui la tua frase: ");
            string fraseInserita = Console.ReadLine();

            char[] fraseDuplicata = new char[fraseInserita.Length];
            // string fraseFinale = "";
            for (int f = 0; f <= fraseInserita.Length - 1; f++)
            {
                fraseDuplicata[f] = fraseInserita[f];
                // fraseFinale = fraseFinale + fraseDuplicata[f];
            }
            Console.Write($"la frase che hai inserito è: {fraseInserita},\nquella duplicata è: {string.Join("", fraseDuplicata)}.\nIl numero dei caratteri copiati è {fraseInserita.Length}");
        }

        static void Esercizio9()
        {
            //Write a program in C# Sharp to count a total number of vowel or consonant in a string
            Console.WriteLine("Inserisci ui la tua frase: ");
            string fraseInserita = Console.ReadLine();
            int conteggioVocali = 0;
            int conteggioConsonanti = 0;
            char[] elencoVocali = new char[] { 'a', 'e', 'i', 'o', 'u', 'ì', 'è', 'é', 'ò', 'à', 'ù' };

            // bool contieneVocali = false;

            for (int f = 0; f <= fraseInserita.Length - 1; f++)
            {
                if (fraseInserita[f] == 'a' || fraseInserita[f] == 'e' || fraseInserita[f] == 'i' || fraseInserita[f] == 'o' || fraseInserita[f] == 'u' || fraseInserita[f] == 'ì' || fraseInserita[f] == 'è' || fraseInserita[f] == 'é' || fraseInserita[f] == 'ò' || fraseInserita[f] == 'à' || fraseInserita[f] == 'ù')
                {
                    conteggioVocali++;
                }
                else if (fraseInserita[f] >= 'b' && fraseInserita[f] <= 'z')
                {
                    conteggioConsonanti++;
                }
            }
            Console.WriteLine($"la frse inserita contine n.{conteggioVocali} vocali e n.{conteggioConsonanti} consonanti");
        }

        static void Esercizio10()
        {
            Console.WriteLine("Write a program in C# Sharp to find maximum occurring character in a string");
            int conteggioOccorenza = 0;
            char parolaPiuFrequente = ' ';
            //char currentWord;
            Console.WriteLine("Scrivi qui la tua frase: ");
            string fraseInserita = Console.ReadLine();

            //char[] caratteriDaEliminare = new char[] { ' ', '/', '\\','!','?' };
            //string[] fraseDopoSplit = fraseInserita.Split(caratteriDaEliminare, StringSplitOptions.RemoveEmptyEntries);
            //char[] caratteriDaEsaminare = new char[fraseDopoSplit.Length];
            //char[] caratteriDuplicati = new char[caratteridaEsaminare.Length];

            for (int e = 0; e <= fraseInserita.Length - 1; e++)
            {
                parolaPiuFrequente = fraseInserita[e];
                for (int d = e + 1; d <= fraseInserita.Length - 1; d++)
                {

                    if (parolaPiuFrequente == fraseInserita[d])
                    {
                        conteggioOccorenza++;
                    }

                }
            }
            Console.Write($"{conteggioOccorenza}");


        }

        static void Esercizio11()
        {
            Console.WriteLine("Write a program in C# Sharp to sort a string array in ascending order");
            Console.WriteLine("Scrivi qui la tua frase: ");
            string fraseInserita = Console.ReadLine();
            char temp = ' ';

            for (int o = 0; o < fraseInserita.Length - 1; o++)
            {
                for (int u = o + 1; u < fraseInserita.Length; u++)
                {
                    if (fraseInserita[o] > fraseInserita[u])
                    {
                        temp = fraseInserita[o];
                        //  fraseInserita[o] = fraseInserita[u];
                        // fraseInserita[u] = temp;
                    }
                }
            }

        }

        static void Esercizio12()
        {
            Console.WriteLine("Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort");
            Console.Write("inserisci qui il numero di frasi che vuoi inserire: ");
            int numeroInserito = Convert.ToInt32(Console.ReadLine());
            string[] fraseInserita = new string[numeroInserito];
            Console.Write($"Inserisci di seguito le {numeroInserito} frasi:\n");
            for (int f = 0; f < numeroInserito; f++)
            {
                fraseInserita[f] = Console.ReadLine();
            }

            string temp = " ";

            for (int f = 0; f < fraseInserita.Length; f++)
            {
                for (int i = 0; i < fraseInserita.Length - 1; i++)
                {
                    if (fraseInserita[i].CompareTo(fraseInserita[i + 1]) > 0)
                    {
                        temp = fraseInserita[i];
                        fraseInserita[i] = fraseInserita[i + 1];
                        fraseInserita[i + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"il riordinamento delle frasi insertite è questo: \n");
            for (int f = 0; f < fraseInserita.Length; f++)
            {
                Console.Write(fraseInserita[f] + " ");
            }
            /*string[] arr1;
            string temp;
            int n, i, j, l;

            Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("Input number of strings :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            l = arr1.Length;

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n\nAfter sorting the array appears like : \n");
            for (i = 0; i < l; i++)
            {
                Console.WriteLine(arr1[i] + " ");
            }*/

        }

        static void Esercizio13()
        {
            Console.WriteLine("Write a program in C# Sharp to extract a substring from a given string without using the library function.");
            Console.Write("inserisci la frase: ");
            string fraseInserita = Console.ReadLine();
            Console.Write("inserisci la posizione da cui iniziare l'estrazione: ");
            int posEstrazione = Convert.ToInt32(Console.ReadLine());
            Console.Write("inserisci la lunghezza della sottostringa: ");
            int lungSubString = Convert.ToInt32(Console.ReadLine());
            
            string fraseFinale = " ";
            char[] fraseDaCreare = new char[fraseInserita.Length];
            for (int f = posEstrazione; f <= lungSubString; f++)
            {
                fraseDaCreare[f] = fraseInserita[f];
                fraseFinale = fraseFinale + fraseDaCreare[f];
            }
            Console.Write($"dalla posizione scelta {posEstrazione} è stata creata la seguente frase: \"{fraseFinale}\" di lunghezza {lungSubString} ");

        }

        static void Esercizio14()
        {
            Console.WriteLine("Write a C# Sharp program to check whether a given substring is present in the given string");
            Console.Write("Inserisci la frase: ");
            string fraseInserita = Console.ReadLine();
            Console.Write("Inserisci la frese da cercare: ");
            string stringaDaCercare = Console.ReadLine();
            string[] stringSeparator = new string[] { " " };

            string[] stringadaAnalizzare = fraseInserita.Split(stringSeparator, StringSplitOptions.None);
            for (int f = 0; f < stringadaAnalizzare.Length - 1; f++)
            {
                if (stringaDaCercare == stringadaAnalizzare[f])
                {
                    Console.WriteLine("esiste la corrispondenza");
                    break;
                }
                //questa modalità di svolgimento non mi consente di avere una risposta univoca in caso contrario
            }
        }

        static void Esercizio14Bis()
        {
            Console.WriteLine("Write a C# Sharp program to check whether a given substring is present in the given string");
            Console.Write("Inserisci la frase: ");
            string fraseInserita = Console.ReadLine();
            Console.Write("Inserisci la frese da cercare: ");
            string stringaDaCercare = Console.ReadLine();

            bool ricercaPositiva = fraseInserita.Contains(stringaDaCercare);
            if (ricercaPositiva == true)
            {
                Console.WriteLine("Esiste la corrispondenza");
            }
            else
            {
                Console.WriteLine("Non esiste corrispondenza");
            }

        }

        static void Esercizio15()
        {
            Console.WriteLine("Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa");
            Console.Write("Scrivi qui la tua frase: ");
            string fraseInserita = Console.ReadLine();

            char[] caratteriDaCambiare = fraseInserita.ToCharArray();
            char ch;
            for (int c = 0; c <=
                caratteriDaCambiare.Length - 1; c++)
            {
                ch = caratteriDaCambiare[c];
                if (Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                {
                    Console.Write(Char.ToLower(ch));
                }
                //Console.WriteLine("");
            }
        }
    }
}

