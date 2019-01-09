using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public class Livraison : Vente
    {
        private decimal fraisTransport;

        public Livraison(string client, decimal remise, decimal frais):
            base(client, remise)
        {
            fraisTransport = frais;
            }
        public override decimal GetTotal()
        {
            decimal total = 0;

            foreach (LigneVente l in lignes)
            {
                total += l.TotalLigne();
            }

            return total + fraisTransport;
        }

        public override void Afficher()
        {
            Console.WriteLine("Livraison");
            base.Afficher();
            Console.WriteLine("Frais de Transport: {0}", fraisTransport);
            Console.WriteLine("Total Livraison: {0:0.000}", this.GetTotal());
        }

    }
}