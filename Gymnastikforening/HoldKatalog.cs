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

        public void TilføjHold(Hold hold)
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
            ////Løsning 1
            //foreach (Hold hold in holdListe)
            //{
            //    if (hold.HoldId == holdId)
            //        return hold;
            //}

            //int i = 0;
            //while(i < holdListe.Count)
            //{
            //    if (holdListe[i].HoldId== holdId)
            //    {
            //        return holdListe[i];
            //    }
            //    i++;
            //}
            //return null;

            //Løsning 2
            return holdListe.Find(hold => hold.HoldId == holdId);
            
        }

        public void PrintHoldListe()
        {
            ////Løsning 1
            //foreach (Hold hold in holdListe)
            //{
            //    Console.WriteLine(hold);
            //}

            //Løsning 2
            holdListe.ForEach(hold => Console.WriteLine(hold));
        }

        

        public List<Hold> HentHoldListe(string holdNavn)
        {
            ////Løsning 1
            //List<Hold> liste = new List<Hold>();
            //foreach (Hold hold in holdListe)
            //{
            //    if (hold.HoldNavn == holdNavn)
            //    {
            //        liste.Add(hold);
            //    }
            //}
            //return liste;
            
            //løsning 2
            return holdListe.Where(hold => hold.HoldNavn == holdNavn).ToList();

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
            ////Løsning 1
            //int sum = 0;
            //foreach (Hold hold in holdListe)
            //{
            //    sum += hold.AntalTilmeldte();
            //}
            //return sum;

            //Løsning 2
            return holdListe.Sum(hold => hold.AntalTilmeldte());
        }

        public int GennemsnitligeDeltagerePrHold() {
            return SamletAntalDeltagerePåAlleHold() / holdListe.Count();
        }

        public int FlestDeltagerePåHold() {
            int sum = 0;
            for (int i = 0; i < holdListe.Count; i++)
            {
                if (sum < holdListe[i].AntalTilmeldte())
                {
                    sum = holdListe[i].AntalTilmeldte();
                }
            }
            return sum;
        }

        public Hold HoldMedFlestDeltagere() {
            Hold holdDeltagere = null;
            int højesteSum = int.MinValue;
            foreach (Hold h in holdListe) {
                int sum = h.AntalTilmeldte();
                if (sum > højesteSum) {
                    højesteSum = sum;
                    holdDeltagere = h;
                }
            }
            return holdDeltagere;
        }

        public double MaxIndtjenningpåHold(Hold hold) {
            ////Løsning 1
            //double sum = 0;
            //foreach (Deltager d in hold.DeltagerListe) {
            //    sum += hold.BeregnTotalPris(d.AntalBørn);
            //}
            //return sum;

            //Løsning 2
            return hold.DeltagerListe.Sum(d => hold.BeregnTotalPris(d.AntalBørn));
        }

        public Hold HoldMedHøjstIndtjenning() {
            Hold hold = null;
            int højesteSum = int.MinValue;
            foreach (Hold h in holdListe)
            {
                int sum = h.AntalTilmeldte();
                if (sum > højesteSum)
                {
                    højesteSum = sum;
                    hold = h;
                }
            }
            return hold;
        }
    }
}
