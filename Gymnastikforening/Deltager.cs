using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening {
    public class Deltager {
        public string ForældreNavn { get; set; }
        public string Adresse { get; set; }
        public int AntalBørn { get; set; }

        public Deltager(string forældreNavn, string adresse, int antalBørn) {
            ForældreNavn = forældreNavn;
            Adresse = adresse;
            AntalBørn = antalBørn;
        }

        public override string ToString() {
            return $"ForældreNavn: {ForældreNavn}, Adresse {Adresse}, AntalBørn: {AntalBørn}";
        }
    }
}
