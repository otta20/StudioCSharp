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
            Esercizio1();
            Esercizio2();
            Esercizio3();
            Esercizio4();
            Esercizio5();
            Esercizio6();
            Esercizio7();
            Esercizio8();

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
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            min = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;
            Console.WriteLine("leoprazioni fra questi due numeri sono: somma: {0}, differenza: {1}, divisione: {2}, prodotto: {3}", sum, min, div, mult);

        

        static void Esercizio7()
        {

                Console.WriteLine("#### ESERCIZIO 7 ####");
        }

        static void Esercizio8()
        {
            Console.WriteLine("#### ESERCIZIO 8 ####");
        }

    }
}
