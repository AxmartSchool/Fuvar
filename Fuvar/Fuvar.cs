using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {

        public int TaxiAzonosito { get; set; }
        public DateTime IndulasIdeje { get; set; }
        public int IdotartamMasodpercben { get; set; }
        public double MegtettUtMerfoldben { get; set; }
        public double ViteldijDollarban { get; set; }
        public double BorravaloDollarban { get; set; }
        public string FizetesModja { get; set; }


        public static void HibakRogzitese(List<Fuvar> hibak)
        {
            var sw = new StreamWriter(@"..\..\hibak.txt", false , Encoding.UTF8 );

            sw.WriteLine("taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja");
            foreach (var fuvar in hibak)
            {
                sw.WriteLine($"{fuvar.TaxiAzonosito};{fuvar.IndulasIdeje};{fuvar.IdotartamMasodpercben};{fuvar.MegtettUtMerfoldben};{fuvar.ViteldijDollarban};{fuvar.BorravaloDollarban};{fuvar.FizetesModja}");
            }
            sw.Close();

        }

        public static List<Fuvar> Beolvasas()
        {
            var output = new List<Fuvar>();
            var sr = new StreamReader(@"..\..\fuvar.csv", Encoding.UTF8);
            string[] temptomb;
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                temptomb = sr.ReadLine().Split(';');

                output.Add(new Fuvar() { TaxiAzonosito = int.Parse(temptomb[0]), IndulasIdeje = DateTime.Parse(temptomb[1]), IdotartamMasodpercben=int.Parse(temptomb[2]), MegtettUtMerfoldben=double.Parse(temptomb[3]), ViteldijDollarban= double.Parse(temptomb[4]), BorravaloDollarban=double.Parse(temptomb[5]), FizetesModja=temptomb[6] });



            }
            sr.Close();

            return output;


        } 


    }
}
