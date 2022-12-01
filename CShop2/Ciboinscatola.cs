using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Ciboinscatola : Prodotto
    {
        private string cibo;
        private string materiale = ("Alluminio");

        public Ciboinscatola(string cibo, string materiale)
        {
            this.cibo = cibo;
            this.materiale = materiale;
        }

        public override void StampaProdotto ()
        {
            Console.WriteLine("Prodotto");
            Console.WriteLine(cibo + "" + materiale);
          
        }
    }
}
