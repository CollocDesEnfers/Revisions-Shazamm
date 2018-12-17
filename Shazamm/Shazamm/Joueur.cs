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
        private int mana =50;
        private string couleurJoueur;
        private int frappe;

        public Joueur(string nom, int numJoueur, int mana)
        {
            this.nom = nom;
            this.numJoueur = numJoueur;
            this.Mana = mana;
        }

        public string Nom { get => nom; set => nom = value; }
        public int NumJoueur { get => numJoueur; set => numJoueur = value; }
        public string CouleurJoueur { get => couleurJoueur; set => couleurJoueur = value; }
        public int Frappe { get => frappe; set => frappe = value; }
        public int Mana { get => mana; set => mana = value; }
    }
}
