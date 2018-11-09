using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            DVD d1 = new DVD("Star Wars IV",210);
            DVD d2 = new DVD("Star Wars V", 123);
            DVD d3 = new DVD("Star Wars VI", 180);
            I_kolcsonozheto k = new Konyv("Harry Potter", "J K Rowling", 8732);
            var katalogus = new List<I_kolcsonozheto>();
            var dvdk = new List<DVD>();
            dvdk.Add(d1);
            dvdk.Add(d2);
            dvdk.Add(d3);
            katalogus.Add(k);
            katalogus.Add(new Ujsag("Kiskegyed",2018,1132));
            katalogus.Add(d1);
            // Console.WriteLine(katalogus[0].MegjelenitendoNev() +"\n"+katalogus[1].MegjelenitendoNev()+"\n"+katalogus[2].MegjelenitendoNev());
            d3.Cim = "Star Wars III";
            Console.WriteLine(dvdk[0].MegjelenitendoNev()+" "+dvdk[0].FutasIdo()+" óra");
            Console.WriteLine(dvdk[1].MegjelenitendoNev()+" "+dvdk[1].FutasIdo()+" óra");
            Console.WriteLine(dvdk[2].MegjelenitendoNev()+" "+dvdk[2].FutasIdo()+" óra");

            dvdk.Sort();
            Console.WriteLine("Hossz szerint rendezve!");
            foreach (var e in dvdk)
            {
                Console.WriteLine(e.MegjelenitendoNev() + " " + e.FutasIdo()+" óra");
            }
            Console.ReadKey();
        }
    }
}
