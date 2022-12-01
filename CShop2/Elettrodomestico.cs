using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Elettrodomestico : Prodotto
    {

        private string altezza;
        private string larghezza;
        private bool corrente = false;


        public Elettrodomestico (string altezza, string larghezza, string corrente)
        {
            this.altezza = altezza;
            this.larghezza = larghezza;

        }

        public void PremiPulsanteOnOff()
        {
            if (corrente == false)
            {
                corrente = true;
                Console.WriteLine("" + nome + " L'elettrodomestico si è acceso");
            }
            else
            {
                Console.WriteLine("" + nome + " L'elettrodomestico si è spento");
            }
        }
}
