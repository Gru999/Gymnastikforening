using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening
{
    public class HoldKatalog
    {
        private List<Hold> holdListe;

        public HoldKatalog()
        {
            holdListe = new List<Hold>();
        }

        public void TilføjHold(Hold hold) // der må ikke være dubletter
        {
            if (FindHold(hold.HoldId) == null)
            {
                holdListe.Add(hold);
            }
            else
            {
                throw new ArgumentException("Der findes allerede et hold med dette HoldID");
            }
           
        }

        public Hold FindHold(string holdId)
        {
            //foreach (Hold hold in holdListe)
            //{
            //    if (hold.HoldId == holdId)
            //        return hold;
            //}
            int i = 0;
            while(i < holdListe.Count)
            {
                if (holdListe[i].HoldId== holdId)
                {
                    return holdListe[i];
                    
                }
                i++;
            }


            return null;
        }

        public void PrintHoldListe()
        {
            foreach (Hold hold in holdListe)
            {
                Console.WriteLine(hold);
            }
        }

        

        public List<Hold> HentHoldListe(string holdNavn)
        {
            List<Hold> liste = new List<Hold>();
            foreach (Hold hold in holdListe)
            {
                if (hold.HoldNavn == holdNavn)
                {
                    liste.Add(hold);
                }
            }
            return liste; 
        }

        public override string ToString()
        {
            string returString = "";
            foreach (Hold hold in holdListe)
            {
                returString = returString + hold.ToString() + " \n";
            }
            return returString;
        }

        public int SamletAntalDeltagerePåAlleHold()
        {
            int sum = 0;
            foreach (Hold hold in holdListe) {
                sum += hold.AntalTilmeldte();
            }
            return sum;

        }

        public int GennemsnitligeDeltagerePrHold() {
            int antal = SamletAntalDeltagerePåAlleHold();
            int antalHold = holdListe.Count;
            return antal / antalHold;
        }

        public int FlestDeltagerePåHold() {
            int sum = 0;
            for (int i = 0; i < holdListe.Count; i++) {
                if (sum < holdListe[i].AntalTilmeldte()) {
                    sum = holdListe[i].AntalTilmeldte();
                }
            }
            return sum;
        }

        //public Hold HoldMedFlestDeltagere() {
        //    int sum = holdListe[0].AntalTilmeldte();
        //    foreach (Hold h in holdListe) {
        //        if (sum < h.AntalTilmeldte()) {
        //            sum = h.AntalTilmeldte();
        //        }
        //    }

        //    Hold h = holdListe.Find(x => x);
        //}

        public double MaxIndtjenningpåHold(Hold hold)
        {
            
            return 0;
        }

        public Hold HoldMedHøjstIndtjenning()
        {
            return null;
        }

      

    }
}
