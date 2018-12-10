using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazamm
{
    class Joueur
    {
        private string nom;
        private int numJoueur;
        private string couleurJoueur;

        public Joueur(string nom, int numJoueur)
        {
            this.Nom = nom;
            this.NumJoueur = numJoueur;
        }

        public string Nom { get => nom; set => nom = value; }
        public int NumJoueur { get => numJoueur; set => numJoueur = value; }
        public string CouleurJoueur { get => couleurJoueur; set => couleurJoueur = value; }
    }
}
