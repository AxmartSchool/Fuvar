using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Program
    {

        static List<Fuvar> Fuvarok;
        static void Main(string[] args)
        {
            Fuvarok = Fuvar.Beolvasas();
            UtazasokSzama();
            TaxisBevetele();
            FizetesiModok();
            OsszesKilometer();
            LeghosszabbFuvar();

            Console.ReadKey();

        }

        private static void LeghosszabbFuvar()
        {

            Console.WriteLine("7. Feladat: Leghosszabb fuvar :");

            //LINQ
            var leghosszabbFuvar = Fuvarok.First(x=>x.IdotartamMasodpercben == Fuvarok.Max(y => y.IdotartamMasodpercben));
            Console.WriteLine($"\tFuvar hossza: {leghosszabbFuvar.IdotartamMasodpercben} masodperc\n\tTaxi azonosito: {leghosszabbFuvar.TaxiAzonosito}\n\tMegtett tavolsag: {leghosszabbFuvar.MegtettUtMerfoldben*1.6} km\n\tViteldij: {leghosszabbFuvar.ViteldijDollarban}$");
            




        }

        private static void OsszesKilometer()
        {
            //LINQ
            Console.WriteLine($"6. Feladat: {(float)Fuvarok.Sum(x=> x.MegtettUtMerfoldben) * 1.6  :#.##}km");


        }

        private static void FizetesiModok()
        {

            Console.WriteLine("5. Feladat: ");
            Dictionary<string, int> fizetesiModok = new Dictionary<string, int>();
            foreach (var fuvar in Fuvarok)
            {

                if (fizetesiModok.ContainsKey(fuvar.FizetesModja))
                {

                    fizetesiModok[fuvar.FizetesModja]++;


                }
                else
                {
                    fizetesiModok.Add(fuvar.FizetesModja, 1);
                }


            }

            foreach (var fizetesiMod in fizetesiModok)
            {

                Console.WriteLine($"\t{fizetesiMod.Key}: {fizetesiMod.Value} fuvar");

            }



        }

        private static void TaxisBevetele()
        {

            int fuvarokSzama = 0;
            double osszBevetel = 0;

            foreach (var fuvar in Fuvarok)
            {

                if (fuvar.TaxiAzonosito == 6185)
                {
                    fuvarokSzama++;
                    osszBevetel += fuvar.ViteldijDollarban + fuvar.BorravaloDollarban;

                }


            }
            //LINQ
            //fuvarokSzama = Fuvarok.Count(x => x.TaxiAzonosito == 6185);

            Console.WriteLine($"4. Feladat: {fuvarokSzama} fuvar alatt {osszBevetel} $");


        }

        private static void UtazasokSzama()
        {

            Console.WriteLine($"3. Feladat: {Fuvarok.Count} fuvar");

        }
    }
}
