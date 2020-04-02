using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Esercizio1();
            //  Esercizio2();
            //  Esercizio3();
            //  Esercizio4();
            //  Esercizio5();
            //  Esercizio6();
            //  Esercizio9();
            //  Esercizio10();
            //  Esercizio11();
            //  Esercizio12();
            //  Esercizio14();
            //  Esercizio15();
            //  Esercizio16();
            //  Esercizio17();
            //  Esercizio16Bis();
            //  Esercizio17Bis();
            //  Esercizio18();
            //  Esercizio19();
            //  Esercizio23();
            //  Esercizio24();
            Esercizio28();
            Console.ReadLine();
        }

        static void Esercizio1()
        {
            string frase1 = "Hello:";
            string nome = "Silvia ";
            string cognome = "Porfiri";
            Console.WriteLine("#### ESERCIZIO 1 ####");
            Console.WriteLine(frase1);
            Console.WriteLine(nome + cognome);

        }


        static void Esercizio2()
        {
            double num1 = 3.14159;
            int num2 = 5;
            Console.WriteLine("#### ESERCIZIO 2 ####");
            Console.WriteLine(num1+num2);
        }

        static void Esercizio3()
        {
            double num1 = 3.14159;
            int num2 = 5;
            Console.WriteLine("#### ESERCIZIO 3 ####");
            Console.WriteLine(num2/num1);
        }

        static void Esercizio4()
        {
            Console.WriteLine("#### ESERCIZIO 4 ####");
            int num1 = 25;
            int num2 = 65;

            Console.WriteLine("Il primo numero è: {0}", num1);
            Console.WriteLine("Il secondo numero è: {0}", num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Dopo lo swap il primo numero è: {0} e il secondo numero è: {1}", num1,num2);
        }

        static void Esercizio5()
        {
            Console.WriteLine("#### ESERCIZIO 5 ####");

            int num1, num2, mult;
          
            Console.WriteLine("inserisci il primo numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            mult = num1 * num2;
            Console.WriteLine("il prodotto dei due numeri è:{0}", mult);
        }

        static void Esercizio6()
        {
            Console.WriteLine("#### ESERCIZIO 6 ####");
            double num1, num2, sum, min, div, mult;

            Console.WriteLine("inserisci il primo numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            sum = num1 + num2;
            min = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;
            Console.WriteLine("le operazioni fra questi due numeri sono: somma: {0}, differenza: {1}, divisione: {2}, prodotto: {3}", sum, min, div, mult);


        }
        static void Esercizio9()
        {
            Console.WriteLine("#### ESERCIZIO 9 ####");
                double num1, num2, num3, num4, average;

                Console.WriteLine("inserisci il primo numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inserisci il secondo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inserisci il terzo numero: ");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inserisci il quarto numero: ");
                num4 = Convert.ToDouble(Console.ReadLine());
               

                average = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine("la media dei numeri {0},{1},{2},{3} è: {4}", num1, num2, num3, num4, average);

        }

        static void Esercizio10()
        {
            Console.WriteLine("#### ESERCIZIO 10 ####");

                double num1, num2, num3, count1, count2 ;
               

                Console.WriteLine("inserisci il primo numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inserisci il secondo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inserisci il terzo numero: ");
                num3 = Convert.ToDouble(Console.ReadLine());

                count1 = ((num1 + num2) * num3);
                count2 = ((num1 * num2) + (num2 * num3));

                Console.WriteLine("il risultato delle operazioni tra i numeri: {0},{1},{2} è: {3} e {4}", num1, num2, num3, count1, count2);

        }
        static void Esercizio11()
        {
            Console.WriteLine("#### ESERCIZIO 11 ####");

            int age;

            Console.WriteLine("Inserisci la tua età:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sembri più giovane rispetto alla tua età di {0} anni", age);

        }

        static void Esercizio12()
        {
            Console.WriteLine("#### ESERCIZIO 12 ####");

            int num1 = 0;
            Console.WriteLine("Inserisci un numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(num1);            
            Console.Write(num1);
            Console.Write(num1);
            Console.WriteLine(num1);

            Console.WriteLine("{0}, {0}, {0}, {0} ", num1);
            Console.WriteLine("{0},{0},{0},{0}", num1);
        }

        static void Esercizio14()
        {
            Console.WriteLine("#### ESERCIZIO 14 ####");

            Console.WriteLine("Inserisci il valore in gradi Celsius:");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("la conversione in scala Kelvin: K= {0}", temp + 273.15);
            Console.WriteLine("la conversione in scala Fahrenheit: F= {0}", (temp * 1.8000) + 32);

        }

        static void Esercizio18()
        {
            Console.WriteLine("#### ESERCIZIO 18 ####");

            Console.WriteLine("Inserisci il primo numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0)
            {
                Console.WriteLine("Vero");
            }
            else Console.WriteLine("Falso");
        }

        static void Esercizio19()
        {
            Console.WriteLine("#### ESERCIZIO 19 ####");
            int num1, num2, sum, mult;
           
            Console.WriteLine("Inserisci il primo numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            mult = sum * 3;

            if (num1 == num2)
            {
                Console.WriteLine("Questo è il risultato richiesto: {0} e {1} ", sum, mult);
            }
            else Console.WriteLine("Questo è il risultato: {0}", sum);

        }

        static void Esercizio20()
        {
            Console.WriteLine("#### ESERCIZIO 20 ####");

            Console.WriteLine("Inserisci il primo numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int absolute = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine("il doppio del valore assoluto di {0} - {1} è = {2}", num1, num2, absolute * 2);
            }
            else Console.WriteLine("il valore assoluto di {0} - {1} è = {2}", num1, num2, absolute);
        }

        static void Esercizio15()
        {
            Console.WriteLine("#### ESERCIZIO 15 ####");
            // Write a C# program that remove a specified character from a non-empty string using a index of character es: w3resource
            string stringaDaModificare = "w3resource";
            string stringaDaStampare0 = stringaDaModificare.Remove(2, 1);
            string stringaDaStampare1 = stringaDaModificare.Remove(4, 1);
            string stringaDaStampare2 = stringaDaModificare.Remove(8, 1);
            Console.Write($"Da questa stringa {stringaDaModificare} genera queste stringhe: \n {stringaDaStampare0}, \n {stringaDaStampare1}, \n {stringaDaStampare2}.");

        }

        static void Esercizio16()
        {
            Console.WriteLine("#### ESERCIZIO 16 ####");
            //Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            string stringa1 = "Machebellagiornata";
            string stringa2 = "Eserciziodistile";

            string stringaDaStampare0 = stringa1.Substring(stringa1.Length - 1,1) + stringa1.Substring(1, stringa1.Length - 2) + stringa1.Substring(0,1);
            string stringaDaStampare1 = stringa2.Substring(stringa2.Length-1,1) + stringa2.Substring(1,stringa2.Length-2) + stringa2.Substring(0,1);
            string stringaDaStampare2 = stringa1.Substring(stringa1.Length - 1, 1) + stringa2.Substring(1, stringa2.Length - 2) + stringa1.Substring(stringa1.Length - 1, 1);
            Console.WriteLine(stringaDaStampare0);
            Console.WriteLine(stringaDaStampare1);
            Console.WriteLine(stringaDaStampare2);
        }

        static void Esercizio17()
        {
            Console.WriteLine("#### ESERCIZIO 17 ####");
            // Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back

            string stringa1 = "Ma che bella giornata di programmazione in C#";

            string stringaModificata = stringa1.Substring(0, 1) + stringa1 + stringa1.Substring(0,1);
            Console.Write(stringaModificata);

        }
       
        static void Esercizio16Bis()
        {
            Console.WriteLine("#### ESERCIZIO 16 BIS ####");
            string stringaImmessa;
            Console.WriteLine("\n inserisci qui la tua stringa da modificare: ");
            stringaImmessa = Console.ReadLine();

            if(stringaImmessa.Length>=1)
            {
                var firtsChar = stringaImmessa.Substring(0, 1);
                var lastChar = stringaImmessa.Substring(stringaImmessa.Length-1, 1);
                string stringaManipolata = stringaImmessa.Substring(1, stringaImmessa.Length - 2);

                Console.WriteLine(lastChar + stringaManipolata + firtsChar);
            }

        }

        static void Esercizio17Bis()
        {
            Console.WriteLine("#### ESERCIZIO 17 BIS ####");
            string stringaImmessa;
            Console.WriteLine("inserisci qui la tua stringa da modificare: ");
            stringaImmessa = Console.ReadLine();

            if (stringaImmessa.Length >= 1)
            {
                var firtsChar = stringaImmessa.Substring(0, 1);
                Console.WriteLine(firtsChar + stringaImmessa + firtsChar);

            }

        }

        static void Esercizio23()
        {
            Console.WriteLine("#### ESERCIZIO 23 ####");
            //Write a C# program to convert a given string into lowercase
            string stringaDaModificare;

            Console.WriteLine("Inserisci la frase da modificare");
            stringaDaModificare = Console.ReadLine();
            Console.WriteLine($"questa è la tua frase trasformata:\n{stringaDaModificare.ToUpper()}");
        }

        static void Esercizio24()
        {
            Console.WriteLine("#### ESERCIZIO 24 ####");
            //Write a C# program to find the longest word in a string
            //string stringaImmessa = "Write a C# Sharp Program to display the following pattern using the alphabet";
            //inseriamo la frase da analizzare
            Console.WriteLine("Inserisci qui la frase che vuoi analizzare: ");
            string stringaDaAnalizzare;
            stringaDaAnalizzare = Console.ReadLine();
            if(stringaDaAnalizzare == "")
            {
                Console.WriteLine("per iniziare l'analisi devi inserire almeno una parola");
            }
            else { 
                char[] separatori = new char[] {' ', ',', '!', ';', '?'};
         
                string[] words = stringaDaAnalizzare.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
                string longestWord, currWord;
                longestWord = "";
                for(int w=0; w < words.Length-1; w++)
                {
                    currWord = words[w];
                    if(currWord.Length > longestWord.Length)
                    {
                        longestWord = currWord;
                    }
                }
               /* primo algoritmo pensato
                 
                for(int w=0; w < words.Length-1; w++)
                {
                    string currWord = words[w];
                    string nextWord = words[w + 1];
                    string temp = "";
                    if (currWord.Length < nextWord.Length)
                    {
                        temp = nextWord;
                    }
                    else
                    {
                        temp = currWord;
                    }
                    if (temp.Length > longestWord.Length)
                    {
                        longestWord = temp;
                    }
                }
                */
                Console.WriteLine($"la stringa più lunga tra quelle inserite è: {longestWord}");

            }



        }

        static void Esercizio28()
        {
            Console.WriteLine("### ESERCIZIO 28 ###");
            //Write a C# program to reverse the words of a sentence
            Console.WriteLine("Scrivi qui la frase: ");
            string stringaInserita = Console.ReadLine();

            string[] miaScarpiera = stringaInserita.Split();
            string[] scarpieraInversa = new string[miaScarpiera.Length];
            int i = 0;
            for(int s = miaScarpiera.Length-1; s>=0; s--)
            {
                string currScarpa = miaScarpiera[s];
                scarpieraInversa[i] = currScarpa;
                i++;
            }
            string fraseFinale = "";
            for (i=0;i <= scarpieraInversa.Length-1; i++)
            {
                fraseFinale = fraseFinale + scarpieraInversa[i] + " ";
            }
            Console.WriteLine(fraseFinale);
        }
    }

}