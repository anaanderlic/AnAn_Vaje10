using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NALOGA 1

            Console.WriteLine("Naloga 1:");
            Console.WriteLine();

            int[] tabelaStevil = new int[] { 2, 4, 7, 9, 10, 11, 13, 14, 17, 19, 20, 21, 25, 35, 49 };

            // A) izpiši vsoto števil iz tabele tabelaStevil, ki pri deljenju s 4 dajo ostanek 0 ali 2. 
            // Poizvedbo zapiši v obliki METODE.

            var vsota = tabelaStevil.Where(stevilo => stevilo % 4 == 0 || stevilo % 4 == 2).Sum(stevilo => stevilo);

            Console.WriteLine($"Vsota števil, ki dajo pri deljenju s 4 ostanek 0 ali 2 je {vsota}.");
            Console.WriteLine();

            // B) izpiši števila iz tabele tabelaStevil, ki pri deljuenju z številom 7 dajo ostanek 0, 3 ali 5.
            // Poizvedbo zapiši v obliki POIZVEDBE.

            var stevila = from stevilo in tabelaStevil
                          group stevilo by stevilo % 7 into grupe
                          where grupe.Key == 0 || grupe.Key == 3 || grupe.Key == 5
                          select grupe;

            foreach (var ostanek in stevila)
            {
                Console.WriteLine($"Ostanek {ostanek.Key} pri deljenju s 7 dajo števila:");
                foreach (var stevilo in ostanek)
                {
                    Console.WriteLine(stevilo);
                }
            }

            // NALOGA 2

            Console.WriteLine();
            Console.WriteLine("Naloga 2:");
            Console.WriteLine();

            string[] tabelaNizov = new string[] { "Ana", "Lea", "Pia", "Miha", "Polona", "Nina", "Aleksandra", "Matija", "Larisa", "Marinka", "Laura" };

            // A) Nize v tabeli tabelaNizov izpiši kot en skupen niz, ki ima elemente tabele ločene z znakom "-".
            // Poizvedbo zapiši v obliki METODE.

            var skupenNiz = tabelaNizov.Aggregate((prvo, drugo) => prvo + "-" + drugo);
            Console.WriteLine(skupenNiz);
            Console.WriteLine();

            // B) Izpiši besede v tabeli tabelaNizov, ki vsebujejo natanko dva a-ja (ne razlikujemo med velikimi in malimi črkami)
            // Uredi jih po prvi črki besede in nato po dolžini od najdaljše do najkrajše.
            // Poizvedbo zapiši v obliki METODE.

            var poizvedba = tabelaNizov.Where(beseda => beseda.ToLower().Split('a').Length == 3).OrderBy(beseda => beseda).ThenByDescending(beseda => beseda.Length);

            foreach (var beseda in poizvedba)
            {
                Console.WriteLine(beseda);
            }
        }
    }
}
