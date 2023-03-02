using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening { 
    public class Addministrator : Ansat {
        public string AnsvarsOmråde { get; set; }


        public Addministrator(string ansvarsområde, string name, string address, string mobilNr, string stilling ) : base(name, address, mobilNr, stilling) {
            AnsvarsOmråde = ansvarsområde;
        }

        public override double beregnLøn() {
            if (Stilling.Equals("Direktør")) {
                return _basisLøn + 15000.0;
            } else {
                return _basisLøn + 5000.0; ;
            }
        }

        public override string ToString() {
            return $"\tAnsvarsOmråde: {AnsvarsOmråde}" + base.ToString();
        }
    }
}
