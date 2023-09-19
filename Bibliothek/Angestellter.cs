using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    internal class Angestellter
    {
        public string Name { get; set; }
        public void ExemplarAdd(Bibliothek bibliothek, Buch buch, int menge)
        {
            if (bibliothek.BuchList.Find(x => x.Equals(buch)) == null)
            { Console.WriteLine("Buch nicht vorhanden!"); }
            else if (bibliothek.BuchList.Find(x => x.Equals(buch)) != null)
            {
                int exemplaranzahl;
                if (bibliothek.ExemplarList.Count == 0) exemplaranzahl = 1;
                else exemplaranzahl = bibliothek.ExemplarList.Count;
                for (int i = 0; i < menge; i++)
                {
                    bibliothek.ExemplarList.Add(new Exemplar()
                    {
                        Buch = buch,
                        isAvailable = true,
                        ExemplarID = exemplaranzahl++,
                        Verfassung = "OK"
                    });
                }
            }
        }
        public void BuchAdd(Bibliothek bibliothek, Buch buch)
        {
            if (bibliothek.BuchList.Find(x => x.Equals(buch)) != null)
                Console.WriteLine("Buch ist bereits vorhanden");
            else if (bibliothek.BuchList.Find(x => x.Equals(buch)) == null)
            {
                bibliothek.BuchList.Add(buch);
            }
        }
        public void BookRemove(Bibliothek bibliothek, Buch buch)
        {
            if (bibliothek.BuchList.Find(x => x.Equals(buch)) != null)
            {
                bibliothek.BuchList.Remove(buch);
            }
            else if ((bibliothek.BuchList.Find(x => x.Equals(buch)) == null))
            {
                Console.WriteLine("Buch konnte nicht gefunden werden");
            }
        }
        public void BuchAusleihen(Bibliothek bibliothek, Buch buch)
        {
            if (bibliothek.BuchList.Contains(buch))
            {
                int index = bibliothek.ExemplarList.FindIndex(x => x.Equals(buch) && x.isAvailable);
                Console.WriteLine("Exemplar gefunden mit ID: " + bibliothek.ExemplarList[index].ExemplarID);
                bibliothek.ExemplarList[index].isAvailable = false;
            }
            else Console.WriteLine("Das Buch konnte nicht gefunden werden!");
        }
        public void BuchRueckgabe(Bibliothek bib, Exemplar exemplar)
        {
            int index = bib.ExemplarList.FindIndex(x => x.ExemplarID == exemplar.ExemplarID);
            bib.ExemplarList[index].isAvailable = true;
        }
        public void AddBesucher(Bibliothek bib)
        {           
            Console.WriteLine("Geben Sie den Namen des Benutzers ein.");
            string name = Console.ReadLine();
            bib.BesucherListe.Add(new Besucher() { Name = name});
        }
    }
}
