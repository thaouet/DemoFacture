using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public class Facture : Vente
    {
        private decimal taxe;

        public Facture(string client, decimal remise,decimal taxe) :base(client,remise)
        {
            this.taxe = taxe;
        }

        public override decimal GetTotal()
        {
            decimal total = 0;

            foreach (LigneVente l in lignes)
            {
                total += l.TotalLigne();
            }

            return total *(1+taxe/100);
        }


        public override void Afficher()
        {
            Console.WriteLine("Facture");
            base.Afficher();
            Console.WriteLine("Taxe: {0} %", taxe);
            Console.WriteLine("Total Facture: {0:0.000}", this.GetTotal());
        }
    }
}