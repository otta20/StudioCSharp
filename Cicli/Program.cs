using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicli
{
    class Program
    {
        static void Main(string[] args)
        {
            // tutto ciò che si può gestire con il for è gestito in maniera più evoluta dal while, do while e foreach
            // il for ha 3 parti tutte scritte in una sola riga di intestazione: 
            // 1) dichiarazione e inizializzazione di un indice
            // 2) "la guardia" il test boleano che indica la condizione per entrare nel corpo del for o uscire
            // 3) l'operazione finale (in genere incremento o decremento dell'indice) che viene eseguita sempre alla fine di ogni ciclo
            // while e do while sono versioni semplificate a livello di sintassi:

            // DO WHILE:
            // è composto da due parti:  
            // 1) il corpo che rappresenta le istruzioni da eseguire in ogni ciclo 
            // 2) la condizione (test boleano) di continuazione del successivo ciclo
            // rispetto al for rimane fuori la dichiarazione di un indice e l'operazione finale dell'inceremento e/o decremento
            // cosa fa:
            // ripete un ciclo di operazioni alemno una volta e tante volte quanto indica la condizione finale di continuazione

            // WHILE
            // l'esatto opposto del DO WHILE, testa la condizione di continuazione come prima cosa ed eventualmene esegue le operazioni del ciclo

            /* string[] arrayDiEsempio = new string[5];
            for (int e = 0; e < arrayDiEsempio.Length-1; e++)
            {
                // operazioni da eseguire...
            }

            int f=0;
            do
            {
                // operazioni da eseguire...
                f++;
            }
            while (f < arrayDiEsempio.Length-1);

            int a = 0;
            while (a < arrayDiEsempio.Length - 1)
            {
                // operazioni da eseguire...
                a++;
            }*/

            // QUIZ: hai a disposizione un tot di domande da porre al concorrente del quiz numerate da 1 a tot; 
            // ogni domanda deve avere una risposta
            // chiedi al concorrente un numero che corrispondente alla domanda che gli verrà posta
            // poni al concorrente la domanda scelta e ne attendi la risposta
            // se il concorrente risponde correttamente, stampa un messaggio di vittoria e richiedi un altro numero di domanda
            // altrimenti, ripeti la domanda fino a un massimo di 3 volte
            // se non ottieni la risposta giusta entro 3 volte, stampa un messaggio di sconfitta e richiedi un altro nuemro di domanda
            // in generale, al momento della richiesta della domanda il concorrente premendo un tasto può uscire dal gioco: es: premi esc per uscire...
            //VersioneBase();
            VersioneConFunzioni();
        }

        static void VersioneBase()
        {
            string[] domandeQuiz = new string[5] { "Qual è il libro di maggior successo di Umberto Eco?", "Qual è il libro di maggior successo di Gabriel Garcia Marquez?", "Qual è il libro di maggior successo di Paolo Choelo?", "Qual è il libro di maggior successo di Isabel Allende?", "Qual è il libro di maggior successo di J.K.Rowling?" };
            string[] risposteQuiz = new string[5] { "Il nome della Rosa", "Cent'anni di solitudine", "L'Alchimista", "La casa degli spiriti", "La saga di Harry Potter" };

            Console.WriteLine("Iniziamo il QUIZZONE, vediamo se sei un attento amante della letteratura...");
            int scelta;
            int tentativi = 0;
            do
            {
                Console.WriteLine("Scegli un numero da 0 a 4 per giocare oppure 7 per uscire: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta < 0 || scelta > 4 && scelta != 7)
                {
                    Console.WriteLine("il numero inserito non è valido...Inserisci un numero da 0 a 4");
                }
                else if (scelta != 7)
                {
                    bool vittoria = false;
                    do
                    {
                        Console.WriteLine($"{domandeQuiz[scelta]}");
                        string rispostaUtente = Console.ReadLine();
                        if (rispostaUtente.ToLower() == risposteQuiz[scelta].ToLower())
                        {
                            Console.WriteLine("Bravo risposta giusta!");
                            vittoria = true;
                        }
                        else
                        {
                            Console.WriteLine($"Che peccato! Non è la risposta giusta..");
                            tentativi++;
                        }
                    } while (tentativi < 3 && !vittoria);
                    if (tentativi == 3)
                    {
                        Console.WriteLine($"I tuoi tentativi sono esauriti, la risposta giusta è \"{risposteQuiz[scelta]}\"");
                    }
                }

            } while (scelta != 7);

            Console.Write("Grazie per aver giocato con noi!");

            Console.ReadLine();
        }

        static void VersioneConFunzioni()
        {
            // le funzioni hanno 3 elemnti da considerare:
            // 1) il nome descrittivo che deve far capire il suo comportamento, buona prassi è insiziare il nome con una parola (verbo)
            //    che indichi in maniera non ambigua che cosa potrebe restituire (Is, Get, Read, Print, Find...);
            // 2) output -> il tipo restituito (int, string, bool,...) oppure void;
            // 3) input -> la lista di uno o più paramentri formali separati dalla virgola con sintassi "tipo nomeParametro"
            //    il nome del parametro deve essere significativo della semantica che la funziona associa a quel parametro;
            //    N.B.: i paramentri di una funzione in quanto formali non devono esser scambiati per quelli che sono i paramtri attuali
            //    che verranno passati dal chiamante; 
            // Esempio: una funzione che restituisce il nome di un utente a fronte del suo ID:
            // string GetNomeUtente(int idUtente)
            // {
            //      recupera nome utnete da DB;
            // }
            // 
            // Dentro il corpo delle funzioni per restituire un risultato (compatibile con il tipo dichiarato in output) si usa la keyword "return <espressione/variabile>";
            // N.B.: in caso di funzioni con output "void" è possibile usare la Keyword "return;" con l'effetto di uscire dalla funzione senza restituire nulla;
            //
            //
            // Come si chiamano le funzioni->per chiamare una funzione si scrive il nome seguito dalle () con dentro i parametri attuali;
            // N.B.: nel caso la funzione resituisca qualcosa (output !void) tipicamente i risultato ottenuto va assegnato ad una qualche variabile
            // Esempio: string nome = GetNomeUtente(idUtente)

            string[] domandeQuiz = new string[5] { "Qual è il libro di maggior successo di Umberto Eco?", "Qual è il libro di maggior successo di Gabriel Garcia Marquez?", "Qual è il libro di maggior successo di Paolo Choelo?", "Qual è il libro di maggior successo di Isabel Allende?", "Qual è il libro di maggior successo di J.K.Rowling?" };
            string[] risposteQuiz = new string[5] { "Il nome della Rosa", "Cent'anni di solitudine", "L'Alchimista", "La casa degli spiriti", "La saga di Harry Potter" };
            int maxAttempts = 3;
            do
            {
                int userChoice = GetUserChoice();
                if (IsValidChoice(userChoice))
                {
                    //scelta vaida, verificose l'utente vuole uscire dal gioco
                    if (WouldYouLeave(userChoice))
                    {
                        //l'utente vuole uscire
                        Console.Write("Grazie per aver giocato!");
                        break;
                    }
                    else
                    {
                        // l'utente ha scelto una domanda
                        // per ogni domanda l'utente ha 3 tentativi
                        int attemptsLeft = maxAttempts;

                        do
                        {
                            PrintQuestion(userChoice, domandeQuiz);
                            string userAnswer = GetUserAnswer();
                            if (IsValidAnswer(userAnswer, risposteQuiz, userChoice))
                            {
                                // la risposta è corretta
                                Console.WriteLine("Complimenti! Hai scritto a rispostta giusta...");
                                break;
                            }
                            else
                            {
                                // la risposta non è corretta, l'utente ha tre tentativi per rispondere
                                // ad ogni erroe l'utente perde un tentativo
                                attemptsLeft--;
                                // verifico se ho ancora dei tentativi
                                if (CanRetry(attemptsLeft))
                                {
                                    //stampo di nuovo la domanda
                                    continue;
                                }
                                else
                                {
                                    //ottengo la risposta
                                    string rightAnswer = GetAnswerToQuestion(userChoice, risposteQuiz);
                                    //stampo la risposta corretta
                                    PrintAnswer(rightAnswer);
                                    break;
                                }

                            }
                        }
                        while (true);
                    }
                }
                else
                {
                    //il numero inserito non è un valore accettabile
                    Console.WriteLine("Il numero inserito non è valido");
                    continue;
                }
            }
            while (true);

        }

        static bool IsValidChoice(int choice)
        {
            if (choice < 0 || choice > 4 && choice !=7 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void PrintQuestion(int questionNumber, string[] quizQuestions)
        {
            Console.WriteLine(quizQuestions[questionNumber]);
        }
        static string GetUserAnswer()
        {
            string userAnswer = Console.ReadLine();
            return userAnswer;
        }
        static bool IsValidAnswer(string quizAnswer, string[] quizAnswers, int questionNumber)
        {
            if (quizAnswer.ToLower() == quizAnswers[questionNumber].ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CanRetry(int retryCountLeft)
        {
            if (retryCountLeft > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintAnswer(string rightAnswer)
        {
            Console.WriteLine($"La risposta corretta è: {rightAnswer}");
        }

        static bool WouldYouLeave(int userChoice)
        {
            if (userChoice == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int GetUserChoice()
        {
            Console.WriteLine("Inserisci un numero da 0 a 4 oppure 7 per uscire: ");
           int userChoice = Convert.ToInt32(Console.ReadLine());
           return userChoice; 
        }
        static string GetAnswerToQuestion(int questionNumber, string[] quizAnswers)
        {
            string answer = quizAnswers[questionNumber];
            return answer;
        }
    }
}
