using System.Dynamic;

namespace Dedicnost
{
    class Postava
    {
        private string jmeno;

        private int id;

        public int ID   
        (
            get{return id;}
        )
        
        public string Jmeno
        {
            get{return jmeno;}
            set{jmeno = value;}
        }
        
        public Postava(string jmeno)
        {
            this.jmeno = jmeno;
            this.id = id;
        }

        public virtual void Utoc()
        {
            Console.WriteLine("Postava útočí klackem");
        }

        public void Predstavse()
        {
            Console.WriteLine($"Jmenuji se {jmeno}");
        }

    }
}