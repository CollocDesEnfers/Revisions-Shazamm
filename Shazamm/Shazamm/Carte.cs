using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazamm
{
    class Carte
    {
        private int numCarte;
        private string nomCarte;
        public Carte(int numCarte)
        {
            this.NumCarte = numCarte;
        }

        public int NumCarte { get => numCarte; set => numCarte = value; }
        public string NomCarte { get => nomCarte; set => nomCarte = value; }

        public override string ToString()
        {
            //GAB // On donne le nom à toutes les cartes
            if (numCarte == 1)
            {
                NomCarte = "Carte Mutisme";
            }else if (numCarte == 2)
            {
                NomCarte= "Carte Clone";
            }
            else if (numCarte == 3)
            {
                NomCarte = "Carte Larcin";
            }
            else if (numCarte == 4)
            {
                NomCarte = "Carte Fin de manche";
            }
            else if (numCarte == 5)
            {
                NomCarte = "Carte Milieu";
            }
            else if (numCarte == 6)
            {
                NomCarte = "Carte Recyclage";
            }
            else if (numCarte == 7)
            {
                NomCarte = "Carte Boost attaque";
            }
            else if (numCarte == 8)
            {
                NomCarte = "Carte Double dose";
            }
            else if (numCarte == 9)
            {
                NomCarte = "Carte Qui perd gagne";
            }
            else if (numCarte == 10)
            {
                NomCarte = "Carte Brasier";
            }
            else if (numCarte == 11)
            {
                NomCarte = "Carte Résistance";
            }
            else if (numCarte == 12)
            {
                NomCarte = "Carte Harpagon";
            }
            else if (numCarte == 13)
            {
                NomCarte = "Carte Boost réserve";
            }
            else if (numCarte == 14)
            {
                NomCarte = "Carte Aspiration";
            }
            return base.ToString();
        }

        public void effetCarte() {  //Comportement de toutes les cartes
            //SEB
        }
    }
}
