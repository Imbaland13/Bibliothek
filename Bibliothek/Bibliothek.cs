using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    internal class Bibliothek
    {
        List<Angestellter> angestellters;
        public List<Buch> BuchList { get; set; }
        public List<Exemplar> ExemplarList { get; set; }
        public List<Besucher> BesucherListe { get; set; }
        public Admin Admin { get; set; } 
        public List<Angestellter> AngestellterListe { get; set; }
    
    }
}
