using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculs_en_Boucle
{
    class Pratique_Calcul_en_Boucle
    {
        static void Main(string[] args)
        {
            Pratique_Calcul_en_Boucle MyInstance = new Pratique_Calcul_en_Boucle();
            MyInstance.CalculSommeEntiers(1, 5);
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            double Resultat = (CalculSommeDoubleListe(liste));
            Console.WriteLine(Resultat);
            Console.ReadLine();
            MyInstance.CalculSommeEntiersCommunsListes();
            Console.ReadLine();
        }
        public void CalculSommeEntiers(int Begin, int End)
        {
            int nbr_variant = 0;
            for (int i = Begin; i <= End; i++)
            {
                nbr_variant = nbr_variant + i;
                Console.WriteLine("La valeur ajouté est " + i + " Le nombre variant est " + nbr_variant);
            }
            Console.ReadLine();
        }

        static double CalculSommeDoubleListe(List<double> liste)
        {

            double Resultat = 0;
            foreach (double valeur in liste)
            {
                Resultat += valeur;
            }
            return Resultat / liste.Count;
            
        }
        public void CalculSommeEntiersCommunsListes()
        {
            List<int> liste3 = new List<int> {0};
            List<int> liste5 = new List<int> { 0 };
            List<int> listeCommun = new List<int> { 0 };
            int Multiple3 = 0;
            int Multiple5 = 0;
            int SommeCommun = 0 ;
            for (int indice = 1; indice <= 33; indice++ )
            {
                Multiple3 += 3;
                liste3.Add(Multiple3);
                Console.WriteLine(Multiple3);
            }
            for (int indice = 1; indice <= 20; indice++)
            {
                Multiple5 += 5;
                liste5.Add(Multiple5);
                Console.WriteLine(Multiple5);
            }
            foreach (int valeur in liste3)
            {
                foreach (int valeurTeste in liste5)
                {
                    if (valeur == valeurTeste)
                    {
                        listeCommun.Add(valeur);
                        Console.WriteLine("valeur commune au deux listes: " + valeur);
                    }

                }
            }
            foreach (int element in listeCommun)
            {
                SommeCommun += element;
                Console.WriteLine("La somme des valeurs communes a chaque itération est = " + SommeCommun);
            }
        }
    }
}
