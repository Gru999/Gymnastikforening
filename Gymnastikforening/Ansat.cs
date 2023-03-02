using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening {
    public class Ansat : IAnsat, IComparable<Ansat> {
		private int _id;
		private string _navn;
		private string _adresse;
		private string _mobilNr;
		private string _stilling;
		private DateTime _ansættelsesDato;

		static int _counter = 1;
        protected int _basisLøn = 5000;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string Navn {
			get { return _navn; }
			set { _navn = value; }
		}
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string MobilNr
        {
            get { return _mobilNr; }
            set { _mobilNr = value; }
        }
        public string Stilling
        {
            get { return _stilling; }
            set { _stilling = value; }
        }
        public DateTime AnsættelsesDato
        {
            get { return _ansættelsesDato;  }
            set { _ansættelsesDato = value;  }
        }

        public Ansat(string navn, string adresse, string mobilNr, string stilling)
        {
            Id = _counter;
            Navn = navn;
            Adresse = adresse;
            MobilNr = mobilNr;
            Stilling = stilling;
            AnsættelsesDato = DateTime.Now;
            _counter++;
        }

        public virtual double beregnLøn() {
            return _basisLøn;
        }

        public override bool Equals(object? obj) {
            //check if object has a value
            if (obj == null) {
                return false;
            }

            //sets obj type to "Ansat"
            var x = (Ansat)obj;
            return x.Id == Id || (x.Navn == Navn && x.MobilNr == MobilNr);
        }

        public override string ToString() {
            return $"\n\tId: {Id}\n\tName: {Navn}\n\tAddress: {Adresse}\n\tMobilNr: {MobilNr}\n\tStilling: {Stilling}\n\tAnsættelsesDato: {AnsættelsesDato}\n\tBasisLøn: {beregnLøn()}";
        }

        public int CompareTo(Ansat? other) {
            return this.Navn.CompareTo(other.Navn);
        }
    }
}
