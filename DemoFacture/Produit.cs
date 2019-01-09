using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public class Produit
    {
        protected string nom;
        protected decimal prix;

        public Produit(Produit p)
        {
            this.nom = p.nom;
            this.prix = p.prix;
        }

        public Produit(string nom, decimal prix)
        {
            this.nom = nom;
            this.prix = prix;
        }

        public override string ToString()
        {
            return String.Format("Produit: {0} - Prix: {1}",nom, prix) ;
        }

        

        public string Nom { get => nom; set => nom = value; }
        public virtual decimal Prix { get => prix; set => prix = value; }

    }
}