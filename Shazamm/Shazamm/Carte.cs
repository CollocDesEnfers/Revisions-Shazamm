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
            //GAB
            if (numCarte == 1)
            {
                NomCarte = "Carte Mutisme";
            }else if (numCarte == 2)
            {
                NomCarte= "Carte Clone";
            }
                return base.ToString();
        }

        public void effetCarte() {
            //SEB
        }
    }
}
