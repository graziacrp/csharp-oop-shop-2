using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Acqua : Prodotto
    {

        public static double maxLitri = 1.5;
        private double readonly ph:
        private string readonly sorgente;
        private double litri;



        public Acqua (string nome, double litri, double ph, string sorgente, double litri ) : base (nome, litri)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }


        public void riempi(double litriDaRiempire)
        {


            if (litri < 0)
            {
                throw new Exception("Non posso riempire senza mettere l'acqua");

            }

            if (litriDaRiempire + this.litri > maxLitri)
            {
                Console.WriteLine("La bottiglia è piena" + litriDaRiempire);
                this.litri = maxLitri;
            }
            else
            {
                Console.WriteLine("Hai fatto uscire l'acqua, la tua bottiglia è ora piena");
                this.litri = this.litri - litriDaRiempire;
            }


            public void Svuota()
            {


                this.litri = 0;
                Console.WriteLine("Hai svuotato la bottiglia!);
            }
        }
