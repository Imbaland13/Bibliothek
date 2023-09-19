using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    internal class Exemplar
    {
        public int ExemplarID { get; set; }
        public Buch Buch { get; set; }
        public bool isAvailable { get; set; }
        public string Verfassung { get; set; }

    }
}
