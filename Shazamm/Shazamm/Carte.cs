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

        //Renvoie vers la méthode carte correspondante au num
        /*public void effetCarte(int num) { // num c'est le numCarte
            switch (num)
            {
                case 1:   //MUTISME

                    break;
                case 2:   //CLONE
                    
                    break;

                case 3: //LARCIN
                    
                    break;
                case 4: //FIN DE MANCHE
                    
                    break;
                case 5: //MILIEU
                    
                    break;
                case 6: //RECYCLAGE
                    
                    break;
                case 7: //BOOST ATTAQUE
                    
                    break;
                case 8: //Double DOSE
                    
                    break;
                case 9: //QUI PERD GAGNE
                    
                    break;
                case 10:       //BRASIER
                    
                    break;
                case 11:    //RESISTANCE
                    
                    break;
                case 12:    //HARPAGON
                    
                    break;
                case 13:    //BOOST RESERVE
                    
                    break;
                case 14:    //ASPIRATION
                    

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            */
    }
}

