using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening
{
    public class SvoemmeHold : Hold
    {
        public string SvoemmeHal { get; set; }

        public SvoemmeHold(string holdId, int år, string holdNavn, double prisPrDeltager, int maxAntalBørn, string svoemmehal):base(holdId,år,holdNavn,prisPrDeltager,maxAntalBørn)
        {
            SvoemmeHal = svoemmehal;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tSvømmehal {SvoemmeHal}";
        }

    }
}
