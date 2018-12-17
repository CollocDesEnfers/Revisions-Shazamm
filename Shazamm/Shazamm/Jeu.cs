using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazamm
{
    class Jeu
    {
        List<Joueur> listDesJoueurs = new List<Joueur>();
        List<Carte> listCarteJ1 = new List<Carte>();
        List<Carte> listCarteJ2 = new List<Carte>();
        List<Carte> listDesCoupsJ1 = new List<Carte>();
        List<Carte> listDesCoupsJ2 = new List<Carte>();
        List<int> nbCases = new List<int>(19);
        int nbTour;
        int nbManche;
        Plateau superPlateau = new Plateau();

        public void debutDuGame() {
            superPlateau.creationPlateau();
            superPlateau.afficherPlateau();
            int nbJoueur = 2;
            Console.WriteLine("Welcome mes Nigga pour une game de Shazamm !!!");
            for (int i = 0; i < nbJoueur; i++) {
                Console.WriteLine("Choix du nom du joueur: ");
                string nomJoueur = Console.In.ReadLine();
                Joueur joueur = new Joueur(nomJoueur,i,50);
                listDesJoueurs.Add(joueur);
            }
            foreach(var j in listDesJoueurs)
            {
                Console.WriteLine("Nous avons les joueurs "+j.Nom);
            }
            distributionCarte();
            afficherListeCarte();
            choixPuissance();
            Console.ReadLine();
        }


        public void choixPuissance() {
            for(int i =0; i<listDesJoueurs.Count;i++) {
                Console.WriteLine("Force du coup: ");
                int chargeCoup = int.Parse(Console.ReadLine());
                listDesJoueurs.ElementAt(i).Frappe = chargeCoup;
                Console.WriteLine("Force du coup: "+ listDesJoueurs.ElementAt(i).Frappe); //ligne test pour voir si la puissance est bonne
                listDesJoueurs.ElementAt(i).Mana -= chargeCoup;
                Console.WriteLine("donc il reste " + listDesJoueurs.ElementAt(i).Mana+" point(s) à "+ listDesJoueurs.ElementAt(i).Nom);
            }
            
            resultatAttaqueJoueur();
            
        }

        public void resultatAttaqueJoueur()
        {
            for (int i = 0; i < listDesJoueurs.Count; i++)
            {
                if (listDesJoueurs.ElementAt(0).Frappe > listDesJoueurs.ElementAt(1).Frappe)
                {
                    Console.WriteLine("Bien joué j1");
                }
                else if (listDesJoueurs.ElementAt(0).Frappe < listDesJoueurs.ElementAt(1).Frappe)
                {
                    Console.WriteLine("Le joueur 2 est plus puissant");
                }
                else if (listDesJoueurs.ElementAt(0).Frappe == listDesJoueurs.ElementAt(1).Frappe)
                {
                    Console.WriteLine("Même force de coups");
                   // Console.WriteLine("coups " + listDesJoueurs.ElementAt(0).Frappe +" coup j2 "+ listDesJoueurs.ElementAt(1).Frappe);
                }
            }
            foreach (var j in listDesJoueurs)
            {
                j.Frappe = 0; // remise à 0 de la mise des joueurs
            }
           
        }

        public void distributionCarte()// faire ça pour la J2
        {
            for (int i=1; i <= 14; i++)
            {
                Carte c = new Carte(i); 
                listCarteJ1.Add(c);
                c.ToString();
            }
        }

        public void afficherListeCarte() {
            foreach(var c in listCarteJ1)
            {
                Console.WriteLine("il y a "+c.NumCarte+" "+c.NomCarte);
            }
        }
    }
}
