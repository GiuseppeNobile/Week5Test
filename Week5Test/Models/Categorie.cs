using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Test.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Categoria { get; set; }

        public virtual IList<Spese> ListaSpese { get; set; }
    }
}
