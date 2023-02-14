using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening {
    public class SvømmeHold : Hold {
        public string SvømmeHal { get; set; }

        public SvømmeHold(string svømmeHal, string holdId, string holdNavn, double prisPrDeltager, int maxAntalBørn) : base(holdId, holdNavn, prisPrDeltager, maxAntalBørn) {
            SvømmeHal = svømmeHal;
        }

        public override string ToString() {
            return $"Svømmehal: {SvømmeHal}, HoldId: {HoldId}, HoldNavn: {HoldNavn}, PrisPrDeltager: {PrisPrDeltager}, MaxAntalBørn: {MaxAntalBørn}";
        }
    }
}
