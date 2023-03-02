using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening {
    public class Hold {
        private List<Deltager> deltagerListe; 

        public List<Deltager> DeltagerListe {
            get { return deltagerListe; }
        }

        public string HoldId { get; set; }
        public int År { get; set; } 
        public string HoldNavn { get; set; }
        public double PrisPrDeltager { get; set; }
        public int MaxAntalBørn { get; set; }

        public Hold(string holdId, int år, string holdNavn, double prisPrDeltager, int maxAntalBørn) {
            HoldId = holdId;
            År = år;
            HoldNavn =holdNavn;
            PrisPrDeltager = prisPrDeltager;
            MaxAntalBørn = maxAntalBørn;
            deltagerListe = new List<Deltager>();
        }

        public void TilmeldDeltager(Deltager deltager) {
            if (deltager.AntalBørn < 1) {
                throw new ArgumentException("Du kan ikke tilføje et antal børn mindre end 1");
            } else {
                if (MaxAntalBørn - AntalTilmeldte() >= deltager.AntalBørn) {
                    deltagerListe.Add(deltager);
                } else {
                    throw new FuldtHoldException("Holdet er fyldt");
                }
            }
        }

        public int AntalTilmeldte() {
            int antal = 0;
            foreach(Deltager deltager in deltagerListe) {
                antal = antal + deltager.AntalBørn;
            }
            return antal;
        }

        public Double BeregnTotalPris(int antalBørn) { 
            double totalPris = 0;
            if (antalBørn >= 1)
                totalPris = PrisPrDeltager + (antalBørn -1) * (PrisPrDeltager*0.5); 
            return totalPris;
        }


        public override string ToString() {
            return $"\tHold id: {HoldId}\n\tÅr: {År}\n\tHoldnavn: {HoldNavn}\n\tPris pr deltager: {PrisPrDeltager}\n\tMax antal børn: {MaxAntalBørn} på holdet\n";
        }
    }
}
