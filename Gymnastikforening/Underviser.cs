using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening {
    public class Underviser : Ansat {
        public string Uddannelse { get; set; }
        public bool BørneAttest { get; set; }

        public Underviser(string uddannelse, bool børneattest, string name, string address, string mobilNr, string stilling) : base(name, address, mobilNr, stilling) {
            Uddannelse = uddannelse;
            BørneAttest = børneattest;
        }

        public override double beregnLøn() {
            if (Stilling.Equals("Instruktør")) {
                return _basisLøn + 10000.0;
            } else {
                return _basisLøn + 5000.0; ;
            }
        }

        public override string ToString() {
            return $"Uddannelse: {Uddannelse}, BørneAttest: {BørneAttest} " + base.ToString();
        }
    }
}
