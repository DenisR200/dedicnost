using System.Reflection.PortableExecutable;

namespace Dedicnost
{
    class Bojovnik: Postava
    {
        private string zbran;

        public Bojovnik(int id, string jmeno, string zbran) : base(jmeno, id)
        {
            this.zbran =zbran;
        }

        public void ZvedniStit()
        {
            Console.WriteLine("Bojovník zvedá štít a brání se...");
        }

        public override void Utoc()
        {
            Console.WriteLine("Útočím" + zbran);   
        }
    }
}