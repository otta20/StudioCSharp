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
            //  Esercizio7();
            //  Esercizio8();
            //  Esercizio9();
            //  Esercizio10();
            //  Esercizio11();
            //  Esercizio12();
            //  Esercizio13();
            Esercizio14();
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
        static void Esercizio7()
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

        static void Esercizio8()
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
        static void Esercizio9()
        {
            Console.WriteLine("#### ESERCIZIO 11 ####");

            int age;

            Console.WriteLine("Inserisci la tua età:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sembri più giovane rispetto alla tua età di {0} anni", age);

        }

        static void Esercizio10()
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

        static void Esercizio11()
        {
            Console.WriteLine("#### ESERCIZIO 14 ####");

            Console.WriteLine("Inserisci il valore in gradi Celsius:");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("la conversione in scala Kelvin: K= {0}", temp + 273.15);
            Console.WriteLine("la conversione in scala Fahrenheit: F= {0}", (temp * 1.8000) + 32);

        }

        static void Esercizio12()
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

        static void Esercizio13()
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

        static void Esercizio14()
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
    }
}