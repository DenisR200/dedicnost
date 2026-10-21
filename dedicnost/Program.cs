using System;
using System.Runtime.Loader;

namespace Dedicnost
{
    class Program
    {
        public static void Main(String[] args)
        {
            //testovací prostředí

            Postava [] legie = new Postava [1000];

            legie[0] = new Bojovnik(1, "Aragorn", "sekera");
            legie[1] = new Bojovnik(1, "Conan", "meč");
            legie[2] = new Kouzelnik(2, "Čáryfuk", 9);

            Boss terminator = new Boss ("T-800", 24, 1000);
            Bojovnik barbar = new Bojovnik("Conan", "meč");
            Kouzelnik caryfuk = new Kouzelnik("Čáryfuk", 40);

            terminator.Utoc();
            terminator.Predstavse();
            Console.WriteLine(terminator.HlaskaBosse());
            barbar.Predstavse();
            barbar.Utoc();
            barbar.ZvedniStit();

            caryfuk.Predstavse();
            caryfuk.Utoc();

            Console.WriteLine(barbar.Jmeno);

            barbar.Jmeno = "Aragon";
            
            Console.WriteLine(barbar.Jmeno);

            Console.WriteLine(caryfuk.Mana);
            
            caryfuk.Meditace();

        }
    }
}