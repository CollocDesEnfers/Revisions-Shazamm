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

        public void debutDuGame() {
            int nbJoueur = 2;
            Console.WriteLine("Welcome mes Nigga pour une game de Shazamm !!!");
            for (int i = 0; i < nbJoueur; i++) {
                Console.WriteLine("Choix du nom du joueur: ");
                string nomJoueur = Console.In.ReadLine();
                Joueur joueur = new Joueur(nomJoueur,i);
                listDesJoueurs.Add(joueur);
            }
            foreach(var j in listDesJoueurs)
            {
                Console.WriteLine("Nous avons les joueurs "+j.Nom);
            }
            distributionCarte();
            afficherListeCarte();
        }


        public void distributionCarte()
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
