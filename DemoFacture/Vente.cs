using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public abstract class Vente:IVente
    {
        static int compteur;
        private int numero;
        private String client;
        private decimal remise;
        public List<LigneVente> lignes;

        public Vente(string client,decimal remise)
        {
            this.numero += compteur++;
            this.client = client;
            this.remise = remise;
            lignes = new List<LigneVente>();
            compteur++;
        }

        public void AjouterLigne(Produit p, decimal qte, decimal remise)
        {
            Boolean trouve = false;
            LigneVente newLigne = new LigneVente(p, remise, qte);
            

            foreach ( LigneVente l in lignes)
            {
                if (l.Equals(newLigne))
                {
                    l.Qte += qte;
                    trouve = true;
                    break;
                }
            }
            if (!trouve )
            lignes.Add(newLigne);
        }

        public virtual void Afficher()
        {
            Console.WriteLine("Numero: {0} - Client: {1}", numero, client);
            Console.WriteLine("Remise: {0} %", remise);
            Console.WriteLine("-------------------");
            foreach (LigneVente l in lignes)
            {
                Console.WriteLine(l.ToString());
            }
            Console.WriteLine("*******************");
        }

        public abstract decimal GetTotal();        
    }
}