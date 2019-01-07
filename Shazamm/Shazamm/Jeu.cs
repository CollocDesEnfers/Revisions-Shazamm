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
        List<Carte> listCarte = new List<Carte>(); //liste générale de toutes les cartes
        List<Carte> listCarteJ1 = new List<Carte>();
        List<Carte> listCarteJ2 = new List<Carte>();
        List<Carte> listDesCoupsJ1 = new List<Carte>();
        List<Carte> listDesCoupsJ2 = new List<Carte>();
        List<int> nbCases = new List<int>(19);
        int nbTour=1;
        int nbManche=1;
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
                Console.WriteLine("Nous avons le joueur "+j.Nom);
            }
            distributionCarte();
            piocheCartes(listDesJoueurs,listCarte, listCarteJ1);  //J1 pioche 5 cartes
            piocheCartes(listDesJoueurs,listCarte, listCarteJ2);  //J2 pioche 5 cartes
            afficherListeCarte();
            while (nbManche < 3)
            {
                choixPuissance();
            }    
            //choixCartes(1,listCarteJ1, listDesCoupsJ1);
            //choixCartes(2, listCarteJ2, listDesCoupsJ2);
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
                /*
                Console.WriteLine("Voulez vous jouer une carte ? O/N");
                string jouerCarte = Console.In.ReadLine();
                if(jouerCarte == "O") {
                    Console.WriteLine("Voulez avez dicidé de jouer une carte... ");
                    choixCartes(i, listCarte, listDesJoueurs.ElementAt(i));
                }
                else
                {
                    Console.WriteLine("Voulez avez dicidé de ne pas jouer de carte... ");
                }
                */

            }
            resultatAttaqueJoueur();
        }

        public void choixCartes(int id ,List<Carte> listCarte, Joueur joueur) //le joueur choisit les cartes qu'il souhaite jouer
        {
            List<Carte> listCoups = new List<Carte>();
            afficherCartesJoueur();
            int choixCarte=1;
            while (choixCarte != 0)
            {
                int superCarte = int.Parse(Console.ReadLine());
                if (superCarte == 0)
                {
                    break;
                }
                else
                {
                    afficherCartesJoueur();
                    Console.WriteLine("Votre choix de carte : ");
                    
                    // //ERREUR
                   // Console.WriteLine("Vous avez sélectionné la carte " + listCoups.Last().NomCarte);
                    foreach (var c in listCarte) {
                        c.effetCarte(superCarte, joueur, superPlateau);

                        if (superCarte == c.NumCarte) {
                            listCoups.Add(c);
                            listCarte.Remove(c);
                        }
                        break;
                    }
                }

            }         
        }

        public void resultatAttaqueJoueur()
        {
            Console.WriteLine("place mur de base" + superPlateau.PlaceMur);
            for (int i = 0; i < listDesJoueurs.Count; i++)
            {
                if (listDesJoueurs.ElementAt(0).Frappe > listDesJoueurs.ElementAt(1).Frappe)
                {
                    if (superPlateau.PlaceMur != superPlateau.PlaceJ2)
                    {
                        Console.WriteLine("Le joueur 1 est plus puissant ");
                        superPlateau.PlaceMur += 1;
                        Console.WriteLine("place mur " + superPlateau.PlaceMur);
                        superPlateau.PlateauCase.Remove("[M]");
                        superPlateau.PlateauCase.Insert(superPlateau.PlaceMur, "[M]");
                        superPlateau.afficherPlateau();
                        nbTour += 1;
                        break;
                    }
                    else if (superPlateau.PlaceMur == superPlateau.PlaceJ2){ // condition si J1 est dans les choux => si le mur arrive sûr J1 
                        Console.WriteLine(" Le joueur 2 est plus puissant (ELSE IF)");
                        superPlateau.PlateauCase.Clear();
                        superPlateau.NbCase -= 2;
                        superPlateau.creationPlateau();
                        Console.WriteLine(" CREATION PLATEAU ELSE IF J1");
                        superPlateau.afficherPlateau();
                        nbTour = 0;
                        nbManche += 1;
                        foreach (var j in listDesJoueurs)
                        {
                            j.Mana = 50;
                        }
                        break;
                    }
                }
                else if (listDesJoueurs.ElementAt(0).Frappe < listDesJoueurs.ElementAt(1).Frappe)
                {
                    if (superPlateau.PlaceMur != superPlateau.PlaceJ1)
                    {
                        Console.WriteLine(" Le joueur 2 est plus puissant ");
                        superPlateau.PlaceMur -= 1;
                        Console.WriteLine("place mur " + superPlateau.PlaceMur);
                        superPlateau.PlateauCase.Remove("[M]");
                        superPlateau.PlateauCase.Insert(superPlateau.PlaceMur, "[M]");
                        superPlateau.afficherPlateau();
                        break;
                    } else if (superPlateau.PlaceMur == superPlateau.PlaceJ1) { // condition si J2 est dans les choux => si le mur arrive sûr J2 
                        Console.WriteLine(" Le joueur 2 est plus puissant (ELSE IF) ");
                        superPlateau.PlateauCase.Clear();
                        superPlateau.NbCase -= 2;
                        superPlateau.creationPlateau();
                        Console.WriteLine(" CREATION PLATEAU ELSE IF J2 ");
                        superPlateau.afficherPlateau();
                        nbTour = 0;
                        nbManche += 1;
                        foreach (var j in listDesJoueurs)
                        {
                            j.Mana = 50;
                        }
                        break;
                    }               
                }
                else if (listDesJoueurs.ElementAt(0).Frappe == listDesJoueurs.ElementAt(1).Frappe)
                {
                    Console.WriteLine(" Même force de coups ");
                    // Console.WriteLine("coups " + listDesJoueurs.ElementAt(0).Frappe +" coup j2 "+ listDesJoueurs.ElementAt(1).Frappe);
                    break;
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
                listCarte.Add(c);
                c.ToString();
            }
        }

        public void piocheCartes(List<Joueur> listDesJoueurs, List<Carte> listCarte, List<Carte> listCarteJ) // Chaque joueur pioche aléatoirement 5 cartes
        {
            int random; // variable qui stockera les int aléatoires
            Random aleatoire = new Random(); // creation de la variable aléatoire Random

            for (int j = 0; j < 5; j++) //Chaque joueur pioche 5 cartes
            {
                //Joueur pioche une carte
                random = aleatoire.Next(listCarte.Count);
                listCarteJ.Add(listCarte.ElementAt(random));
                listCarte.RemoveAt(random); 
            }
           
        }


        public void afficherListeCarte()
        {
            
            foreach (var c in listCarte)
            {
                Console.WriteLine(" " + c.NumCarte + " : " + c.NomCarte);
            }
        }



        public void afficherCartesJoueur() {  //afficher la liste des cartes d'un joueur
            Console.WriteLine("Entrez le numéro de la carte que vous souhaitez jouer, ou 0 pour ne pas en jouer \n\n0 : Ne plus  rien jouer " );
            int numeroCarte = 1;
            Console.WriteLine(" liste des cartes dans liste carte ");
            foreach (var c in listCarte)
            {
                Console.WriteLine(c.NomCarte+" à la place "+ numeroCarte+" dans la liste carte son vrai num est "+ c.NumCarte+" ");
                numeroCarte++;
            }
        }


    }
}
