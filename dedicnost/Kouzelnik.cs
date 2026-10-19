using System.Reflection;

namespace Dedicnost
{
    class Kouzelnik :Postava
    {
        private int mana;
        private int manaMax; 

        public int Mana
        {
            get{return mana;}
            private set{mana = value;}
        }

        public int ManaMax{get => manaMax; set => manaMax = value; }
 
        public Kouzelnik(int id, string jmeno, int mana, int manaMax = 100) : base(jmeno)
        {
            Mana = mana;
            ManaMax = manaMax;
        }

        public override void Utoc()
        {
            if (mana >= 10)
            {
                mana -= 10;
                Console.WriteLine($"Kouzelník sesílá ohnivou kouli... ");
            }
            else
            {
                Console.WriteLine("Nedostaek many, použiji základní útok");
                base.Utoc();
            }
        }

        

        public void Meditace()
        {
            while (ManaMax > Mana)
            {
                if (Mana + 10 > ManaMax)
                {
                    Mana = ManaMax;
                }
                else
                {
                    Mana += 10;
                }


                Thread.Sleep(2000);
                
                Console.WriteLine($"{Jmeno}: Medituji: {Mana}");
            }
        }
        
        
    }
}