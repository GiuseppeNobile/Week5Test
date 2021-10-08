using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Test.Models
{
    public class Spese
    {
        public int Id {get; set;}
        public DateTime Data { get; set; }
        public Categorie Categoria { get; set; }
        public string Descrizione { get; set; }
        public string Utente { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }

    }
}
