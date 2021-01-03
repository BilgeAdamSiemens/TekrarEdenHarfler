using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekrarEdenHarfler
{
    class Program
    {
        static void Main(string[] args)
        {
            string girilenSozcukler;

            while (true)
            {
                Console.Write("\nGirilen karakterlerin sayısı:");
                Console.Write("\n----------------------------------\n");
                Console.Write("Birşeyler giriniz:\n");
                girilenSozcukler = Console.ReadLine();
                Console.Write("\n");
                if (girilenSozcukler == "exit"||girilenSozcukler=="EXIT")
                    break;
                var sozluk = from karakterler in girilenSozcukler
                           group karakterler by karakterler into KarakterGrubu
                           select KarakterGrubu;
                Console.Write("Karakterlerin sayısı:\n");
                foreach (var karakterim in sozluk)
                {
                    Console.WriteLine($"{karakterim.Key}: {karakterim.Count()} kez");
                }
            }
        }
    }
}
