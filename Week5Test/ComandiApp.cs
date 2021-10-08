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

            var selectedCategory = ctx.setCategorie.FirstOrDefault(c => c.Categoria.ToUpper() == categoria.ToUpper());

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
                CategoriaId = selectedCategory,
                Descrizione = descrizione,
                Utente = utente,
                Importo = Convert.ToDecimal(importo),
                Approvato = Convert.ToBoolean(approvato)
            };

            ctx.setSpese.Add(newSpesa);
            ctx.SaveChanges();

            Console.WriteLine("---- Premi un tasto ----");
            Console.ReadKey();

        }
    }
}
