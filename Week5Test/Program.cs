using System;

namespace Week5Test
{
    class Program
    {
        static void Main(string[] args)
        {

            bool quit = false;

            do
            {
                Console.WriteLine("GESTIONE SPESE \n");

                Console.WriteLine("Seleziona comando: \n");

                Console.WriteLine("1 - Lista Spese \n" +
                                  "2 - Inserisci spesa \n" +
                                  "3 - Approva spesa \n" +
                                  "4 - Cancella spesa \n" +
                                  "5 - Lista spese approvate \n" +
                                  "6 - Lista spese utente \n" +
                                  "7 - Totale spese categoria \n" +
                                  "q - Esci");

                string selezione = Console.ReadLine();

                switch (selezione)
                {
                    case "1":
                        ComandiApp.ListaSpese();
                        break;

                    case "2":
                        ComandiApp.InserisciSpesa();
                        break;

                    case "3":
                        ComandiApp.ApprovaSpesa();
                        break;

                    case "4":
                        ComandiApp.CancellaSpesa();
                        break;

                    case "5":
                        ComandiApp.ListaSpeseApprovate();
                        break;

                    case "6":
                        ComandiApp.ListaSpeseUtente();
                        break;

                    case "7":
                        ComandiApp.TotaleSpeseCategoria();
                        break;

                    case "q":
                        quit = true;
                        break;


                }
            } while (!quit);
            
        }
    }
}
