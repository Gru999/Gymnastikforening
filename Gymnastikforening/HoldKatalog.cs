using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening
{
    public class HoldKatalog
    {
        private List<Hold> _holdListe;

        public HoldKatalog()
        {
            _holdListe = new List<Hold>();
        }

        public override string ToString()
        {
            string allInfo = "";
            if (_holdListe.Count > 0)
            {
                foreach (Hold h in _holdListe)
                {
                    allInfo += "\t" + h.ToString() + "\n";
                }
                return $"HoldOplysninger:\n {allInfo}";
            }
            return null;
        }

        public void TilføjHold(Hold hold) {
            foreach (Hold h in _holdListe) {
                if (h.HoldId.Equals(hold.HoldId)) {
                    throw new ArgumentException("Der findes allerede et hold med dette id.");
                }
            }
            _holdListe.Add(hold);
        }

        public Hold FindHold(string holdId)
        {
            //if (_holdListe.Count > 0) {
            //    foreach (Hold h in _holdListe)
            //    {
            //        if (h.HoldId.Equals(holdId))
            //        {
            //            return h;
            //        }
            //    }
            //}
            //return null;
            if (_holdListe.Count > 0)
            {
                int i = 0;
                while (i < _holdListe.Count)
                {
                    if (_holdListe[i].HoldId.Equals(holdId))
                    {
                        return _holdListe[i];
                    }
                    i++;
                }
            }
            return null;
        }
    }
}


