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

            Console.ReadKey();

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
