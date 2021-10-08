using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Test.EntityFramework;
using Week5Test.Models;

namespace Week5Test
{
    public static class ComandiApp
    {
        public static void InserisciSpesa()
        {
            using SpeseContext ctx = new();

            Console.Clear();
            Console.WriteLine("Inserisci nuova spesa: \n");

            Console.WriteLine("Data: ");
            string data = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            string categoria = Console.ReadLine();

            var selectedCategory = ctx.Categorie.FirstOrDefault(c => c.Categoria.ToUpper() == categoria.ToUpper());

            Console.WriteLine("Descrizione: ");
            string descrizione = Console.ReadLine();

            Console.WriteLine("Utente: ");
            string utente = Console.ReadLine();

            Console.WriteLine("Importo: ");
            string importo = Console.ReadLine();

            Console.WriteLine("Approvato: ");
            string approvato = Console.ReadLine();


            Spese newSpesa = new()
            {
                Data = DateTime.Now,
                Categoria = selectedCategory,
                Descrizione = descrizione,
                Utente = utente,
                Importo = Convert.ToDecimal(importo),
                Approvato = Convert.ToBoolean(approvato)
            };

            ctx.Spese.Add(newSpesa);
            ctx.SaveChanges();

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();

        }

        public static void ApprovaSpesa()
        {
            Console.Clear();
            Console.WriteLine("seleziona ID della spesa da approvare: ");
            var IdSpesa = Console.ReadLine();
            var spesaId = Convert.ToInt32(IdSpesa);

            using (SpeseContext ctx = new()) 
            {                
                var spesaNonApprovata = ctx.Spese.FirstOrDefault(s => s.Id == spesaId && s.Approvato == false);
                spesaNonApprovata.Approvato = true;

                ctx.SaveChanges();
            };           

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();
        }

        public static void CancellaSpesa()
        {
            Console.Clear();
            Console.WriteLine("seleziona ID della spesa da cancellare:");
            var IdSpesa = Console.ReadLine();
            var spesaId = Convert.ToInt32(IdSpesa);

            using (SpeseContext ctx = new())
            {
                var spesaDaCancellare = ctx.Spese.FirstOrDefault(s => s.Id == spesaId);
                ctx.Spese.Remove(spesaDaCancellare);

                ctx.SaveChanges();
            }

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();
        }

        public static void ListaSpeseApprovate()
        {
            Console.Clear();
            Console.WriteLine("Lista Spese Approvate: ");

            using (SpeseContext ctx = new())
            {
                ctx.Spese.Where(s => s.Approvato == true).ToList();
            }

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();
        }

        public static void ListaSpeseUtente()
        {
            Console.Clear();
            Console.WriteLine("Selezionare Utente: ");
            var utente = Console.ReadLine();

            using (SpeseContext ctx = new())
            {
                ctx.Spese.Where(s => s.Utente == utente).ToList();
            }

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();
        }

        public static void TotaleSpeseCategoria()
        {
            Console.Clear();
            Console.WriteLine("Selezionare ID Categoria: ");
            var categoria = Console.ReadLine();

            using (SpeseContext ctx = new())
            {
                ctx.Spese.Where(s => Convert.ToString(s.Categoria) == categoria).Sum(s=> s.Importo);
            }

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();
        }

    }
}
