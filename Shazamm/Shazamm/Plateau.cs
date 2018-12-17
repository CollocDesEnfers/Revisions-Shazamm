using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazamm
{
    class Plateau
    {
        List<string> plateauCase = new List<string>();

        public List<string> PlateauCase { get => plateauCase; set => plateauCase = value; }

        public void creationPlateau()
        {
            for (int i = 1; i < 18; i++) { 
                if (i == 6)
                {
                    PlateauCase.Add("[J1]");
                }
                if (i == 9) {
                    PlateauCase.Add("[M]");
                }
                if (i == 12)
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
