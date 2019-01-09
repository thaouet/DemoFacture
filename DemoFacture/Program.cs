using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFacture
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p1 = new Produit("ChupaChupa", 0.85m);
            Produit p2 = new Produit("TicTac", 1.9m);
            Produit p3 = new Produit("KinderSurprise", 3.8m);

            Facture f1 = new Facture("JUJU", 5 , 19);
            Livraison l1 = new Livraison("KIKI", 7 , 10);
            
            f1.AjouterLigne(p1, 4, 0);
            f1.AjouterLigne(p3, 1, 5);
            f1.Afficher();

            


            l1.AjouterLigne(p1, 2, 10);
            l1.AjouterLigne(p2, 1, 0);
            l1.AjouterLigne(p2, 2, 0);

            l1.Afficher();

            

            Console.ReadLine();
        }
    }
}
