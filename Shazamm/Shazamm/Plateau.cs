using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazamm
{
    class Plateau
    {
        int nbCase=18;
        int placeJ1;
        int placeMur;
        int placeJ2;
        List<string> plateauCase = new List<string>();

        public List<string> PlateauCase { get => plateauCase; set => plateauCase = value; }
        public int NbCase { get => nbCase; set => nbCase = value; }
        public int PlaceJ1 { get => placeJ1; set => placeJ1 = value; }
        public int PlaceMur { get => placeMur; set => placeMur = value; }
        public int PlaceJ2 { get => placeJ2; set => placeJ2 = value; }

        public void creationPlateau()
        {
            placeMur = nbCase / 2;
            placeJ1 = placeMur - 2;
            placeJ2 = placeMur + 2;
            for (int i = 1; i < NbCase; i++) { 
                if (i == placeJ1)
                {
                    PlateauCase.Add("[J1]");
                }
                if (i == placeMur) {
                    PlateauCase.Add("[M]");
                }
                if (i == placeJ2)
                {
                    PlateauCase.Add("[J2]");
                }
                else
                {
                    PlateauCase.Add(" [-] ");
                }
            }
            
        }

        public void afficherPlateau()
        {
            
            foreach (var p in PlateauCase)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(plateauCase.Count);
        }
    }
}
