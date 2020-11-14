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


            Console.ReadKey();

        }

        private static void UtazasokSzama()
        {

            Console.WriteLine($"3. Feladat: {Fuvarok.Count} fuvar");

        }
    }
}
