using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            // formati alfanumerici sono char e string

            // dichiarazione
            char unCarattare;   // un singolo carattere
            string unaStringa;  // una concatenazione/sequenza di caratteri

            // assegnamento
            unCarattare = 'a';                  // NB: i caratteri sono case-sensitive
            unaStringa = "";                    // stringa vuota
            unaStringa = string.Empty;          // altra sintassi per la stringa vuota
            unaStringa = "una bella stringa";    // stringa non vuota

            // una stringa la puoi vedere come un array di Char
            int lunghezza = unaStringa.Length;
            char unaLettera = unaStringa[5];

            // caratteri speciali: va fatto l'escaping con il carattere super speciale '\'
            // 1. il carattere '
            char unApice = '\'';
            // 2. il caratere "
            string esempioDoppioApice = "In questa string ci inserisco un doppio apice: \"";
            string doppiaBarra = "Ecco una bella barra: \\";
            string unSaccoDiBarre = "Ecco varie barre: \\\\\\";
            // 3. Ci sono altri caratteri speciali, i più importanti sono il "tab" e il "newline (line break)"
            string nomeECognomeTabbati = "Silvia\t\tPorfiri";
            string stringheTutteACapo = "Uno\nDue\nTre";
            Console.WriteLine(stringheTutteACapo);
            Console.Write("Carattere in posizione 3: {0}", stringheTutteACapo[3]);
            Console.WriteLine("Due volte a capo: {0}", stringheTutteACapo[3]);


            // OPERAZIONI CON LE STRINGHE

            // Concatenazione semplice (+)
            string primaStringa = "Silvia";
            string secondaStringa = "Porfiri";
            string concatenzionePrimaSeconda = primaStringa + secondaStringa;
            string concatezionePiuElaborata = "Nome: " + primaStringa + " - Cognome: " + secondaStringa;
            Console.WriteLine(concatezionePiuElaborata);

            // Concatenazione tramite "formato"
            string concatenazioneTramiteFormat = string.Format("Nome: {0} - Cognome: {1}", primaStringa, secondaStringa);
            Console.WriteLine(concatenazioneTramiteFormat);

            // Concatenzione con formato "nuovo" ($)
            string concatenazioneConDollarSymbol = $"Nome: {primaStringa} - Cognome: {secondaStringa}";


            // Contains
            bool verificaAzioneContains = concatenazioneConDollarSymbol.Contains("Silvia");
            Console.WriteLine($"la variabile \"concatenazioneConDollarSymbol\" contiene Silvia? {verificaAzioneContains}");

            // ToUpper / ToLower
            verificaAzioneContains = concatenazioneConDollarSymbol.ToUpper().Contains("SILVIA");
            Console.WriteLine($"la variabile \"concatenazioneConDollarSymbol\" contiene \'silvia\'? {verificaAzioneContains}");

            // Equals
            // Object --> Int / double .... string 
            // Equals() e' una funzione definita originariamente in Object, quindi la eredita anche String
            // TODO: da studiare più avanti

            // ToString
            // E' un metodo come Equals, cioè ereditato da Object
            // Nel caso delle stringhe, restituisce se stessa
            string xxx = "xxx";
            string uguale = xxx.ToString();


            // IndexOf / IndexOfAny
            string unaStringDaIndicizzare = "Ciao! Cerca qualcosa in questa string! Ti va?";

            char[] charArray = new char[4];
            charArray[0] = 'q';
            charArray[1] = 'a';
            charArray[2] = 'c';
            charArray[3] = 'e';
            var stampaIlRisultato = unaStringDaIndicizzare.IndexOfAny(charArray);
            Console.WriteLine(stampaIlRisultato);

            Console.ReadLine();
        }
    }
}
