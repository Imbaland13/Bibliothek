using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            List<Exemplar> exemplar = new List<Exemplar>();
            Angestellter angestellter = new Angestellter() { Name = "Steve" };
            Buch buch = new Buch();
            Buch buch1 = new Buch();
            Buch buch2 = new Buch();
            List<Buch> buchliste = new List<Buch>
            {
                new Buch() { Name = "Steve Biografie", BuchID = 1 },
                new Buch() { Name = "Bla", BuchID = 2 }
            };
            Bibliothek bibliothek = new Bibliothek() { BuchList = buchliste,ExemplarList = exemplar};
            for (int i = 0; i < 10; i++)
            {
                exemplar.Add(new Exemplar()
                {
                    isAvailable = true,
                    ExemplarID = +1,
                    Verfassung = "Gut",
                    Buch = buchliste[0]
                }) ;
            }
            angestellter.BuchAdd(bibliothek, buchliste[0]);
            Console.WriteLine(bibliothek.ExemplarList.Count);
            angestellter.ExemplarAdd(bibliothek, buchliste[1], 5);
            angestellter.ExemplarAdd(bibliothek, buchliste[0], 5);
            bibliothek.ExemplarList.ForEach(item => { Console.WriteLine(item.Buch.Name + " " + item.ExemplarID);});
            foreach (var item in bibliothek.ExemplarList)
            {
                Console.WriteLine(item.Buch.Name);
                Console.WriteLine(item.ExemplarID);
            }
        }
    }
}