using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening {
    public class Hold {
        //instansfelter hvis der bedesom det
        private List<Deltager> _deltagerListe;

        public string HoldId { get; set; }
        public string HoldNavn { get; set; }
        public double PrisPrDeltager { get; set; }
        public int MaxAntalBørn { get; set; }

        public Hold(string holdId, string holdNavn, double prisPrDeltager, int maxAntalBørn) {
            _deltagerListe = new List<Deltager>();
            HoldId = holdId;
            HoldNavn = holdNavn;
            PrisPrDeltager = prisPrDeltager;
            MaxAntalBørn = maxAntalBørn;
        }

        public override string ToString() {
            return $"HoldId: {HoldId}, HoldNavn: {HoldNavn}, PrisPrDeltager: {PrisPrDeltager}, MaxAntalBørn: {MaxAntalBørn}";
        }

        public int AntalTilmeldte() {
            //tjek om max antal børn er overskredet
            int deltager = 0;
            foreach (Deltager d in _deltagerListe) {
                deltager += d.AntalBørn;
            }
            return deltager;
        }

        public void TilmeldDeltager(Deltager deltager) {
            int restPladser = MaxAntalBørn - deltager.AntalBørn;
            if (MaxAntalBørn > deltager.AntalBørn && restPladser >= deltager.AntalBørn) {
                _deltagerListe.Add(deltager);
            }
            else {
                Console.WriteLine($"Der er desværre ikke plads på holdet.");
            }
        }

        public Double BeregnTotalPris(int antalBørn) {
            double totalPris = 500.0;
            for (int i = 1; i < antalBørn; i++) {
                totalPris += 250.0;
            }
            return totalPris;
        }
    }
}
