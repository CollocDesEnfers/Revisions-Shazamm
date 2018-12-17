﻿using System;
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
            piocheCartes(listDesJoueurs,listCarte, listCarteJ1);  //J1 pioche 5 cartes
            piocheCartes(listDesJoueurs,listCarte, listCarteJ2);  //J2 pioche 5 cartes
            afficherListeCarte();
            choixPuissance();
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
            }
            
            resultatAttaqueJoueur();    
        }

        public void choixCartes(int id ,List<Carte> listCarte, List<Carte> listCoups) //le joueur choisit les cartes qu'il souhaite jouer
        {   
            
            afficherCartesJoueur(id, listCarte);
            int choixCarte=1;
            while (choixCarte != 0)
            {
                choixCarte = int.Parse(Console.ReadLine());
                if (choixCarte == 0)
                {
                    //Console.WriteLine("Vous avez sélectionné les cartes suivantes  ");
                }
                else
                {
              
                    listCoups.Add(listCarte.ElementAt(choixCarte - 1));
                    listCarte.RemoveAt(choixCarte-1);
                    Console.WriteLine("Vous avez sélectionné la carte " + listCoups.Last().NomCarte);

                    afficherCartesJoueur(id, listCarte);

                }

            }         
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



        public void afficherCartesJoueur(int i, List<Carte> listCarte) {  //afficher la liste des cartes d'un joueur
            Console.WriteLine("Joueur "+i+ ",Entrez le numéro de la carte que vous souhaitez jouer, ou 0 pour ne pas en jouer \n\n0 : Ne plus  rien jouer " );
            int numeroCarte = 1;
            foreach (var c in listCarte)
            {
                Console.WriteLine(+numeroCarte + " : "+c.NomCarte);
                numeroCarte++;
            }
        }


    }
}
