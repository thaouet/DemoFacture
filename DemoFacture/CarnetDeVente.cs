using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFacture
{
    public class CarnetDeVente:IComparable
    {
        List<Vente> lesventes;
        private string magasin;
        public CarnetDeVente(string magasin)
        {
            this.magasin = magasin;
            lesventes = new List<Vente>();
        }


        public void AjouterVente (Vente v)
        {
            lesventes.Add(v);
        }

        public int CompareTo(object obj)
        {
         CarnetDeVente   c = (CarnetDeVente)obj;
            if (this.TotalFactures() == c.TotalFactures())
                return 0;
            else
                if (this.TotalFactures() > c.TotalFactures())
                return 1;
            else
                return -1;
        }

        public decimal TotalFactures()
        {
            decimal somme = 0;
            foreach (Vente v in lesventes)
            {
                if (v is Facture)
                    somme += v.GetTotal();
            }
            return somme;
        }


    }
}