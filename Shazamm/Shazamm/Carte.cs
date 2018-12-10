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

        //Renvoie vers la méthode carte correspondante au num
        public void effetCarte(int num) {
            switch (num)
            {
                case 1:
                    mutisme();
                    break;
                case 2:
                    clone();
                    break;

                case 3:
                    larcin();
                    break;
                case 4:
                    finDeManche();
                    break;
                case 5:
                    milieu();
                    break;
                case 6:
                    recyclage();
                    break;
                case 7:
                    boostAttaque();
                    break;
                case 8:
                    doubleDose();
                    break;
                case 9:
                    quiPerdGagne();
                    break;
                case 10:
                    brasier();
                    break;
                case 11:
                    resistance();
                    break;
                case 12:
                    harpagon();
                    break;
                case 13:
                    boostReserve();
                    break;
                case 14:
                    aspiration();

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        //Méthodes des cartes 

        public void mutisme()
        {

        }

        public void clone()
        {

        }


        public void larcin()
        {

        }


        public void finDeManche()
        {

        }


        public void milieu()
        {

        }


        public void recyclage()
        {

        }


        public void boostAttaque()
        {

        }


        public void doubleDose()
        {

        }


        public void quiPerdGagne()
        {

        }


        public void brasier()
        {

        }


        public void resistance()
        {

        }


        public void harpagon()
        {

        }

        public void boostReserve()
        {

        }

        public void aspiration()
        {

        }

      




    }

}
