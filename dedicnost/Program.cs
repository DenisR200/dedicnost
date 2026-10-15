using System;
using System.Runtime.Loader;

namespace Dedicnost
{
    class Program
    {
        public static void Main(String[] args)
        {
            //testovací prostředí
            Bojovnik barbar = new Bojovnik("Conan", "meč");
            Kouzelnik caryfuk = new Kouzelnik("Čáryfuk", 40);

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