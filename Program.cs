using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Random r = new Random();
            List<Diak> jelentkezok = new List<Diak>();
            for (int i = 0; i < 10; i++)
            {
                jelentkezok.Add(new Diak(
                    $"Diak{i + 1}",
                    r.Next(20, 51),
                    r.Next(15, 51)));
            }
            jelentkezok.Add(new Diak("Petike", 0, 0, true));
            Diak.DiakokKiir(jelentkezok);

            foreach (var item in jelentkezok)
            {
                if (item.FelvettekE())
                {
                    Console.WriteLine(item.Nev());
                }
            }
        }
    }
}
