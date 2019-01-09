using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public class LigneVente : Produit
    {
        private decimal remise;
        private decimal qte;
        public LigneVente (Produit p, decimal remise, decimal qte):base(p)
        {
            this.remise = remise;
            this.qte = qte;
        }
        public override decimal Prix
        {
            get { return prix * (1 - remise / 100); }
            set { prix = value/(1-remise/100); }
            
        }

        public decimal Qte { get => qte; set => qte = value; }

        public decimal TotalLigne()
        {
            return Prix * qte;
        }

        public override bool Equals(object obj)
        {
            LigneVente l = (LigneVente)obj;
            if (this.nom == l.nom & this.remise == l.remise)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Remise {0} % - Qte {1} - Total {2} ", remise,qte,TotalLigne());
        }
    }
}