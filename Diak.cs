using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    class Diak
    {
        string nev;
        int magyar;
        int matek;
        bool protekcio;

        public Diak(string nev, int magyar, int matek, bool protekcio = false)
        {
            this.nev = nev;
            this.magyar = magyar;
            this.matek = matek;
            this.protekcio = protekcio;
        }

        int Osszpontszam()
        {
            return magyar + matek;
        }

        public bool FelvettekE()
        {
            return Osszpontszam() >= 65 || protekcio;
        }

        public string Nev()
        {
            return nev;
        }

        public void setNev(string nev)
        {
            if(nev.Contains(" "))
                this.nev = nev;
        }

        public static void DiakokKiir(List<Diak> diakok)
        {
            Console.WriteLine("Név\tMagyar\tMatek");
            foreach (var item in diakok)
            {
                Console.WriteLine($"{item.nev}\t{item.magyar}\t{item.matek}");
            }
        }
    }
}
