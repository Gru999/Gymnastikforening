using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening {
    public class Ansat {
		private int _id;
		private string _name;
		private string _address;
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
		public string Name {
			get { return _name; }
			set { _name = value; }
		}
        public string Address
        {
            get { return _address; }
            set { _address = value; }
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

        public Ansat(string name, string address, string mobilNr, string stilling)
        {
            Id = _counter;
            Name = name;
            Address = address;
            MobilNr = mobilNr;
            Stilling = stilling;
            AnsættelsesDato = DateTime.Now;
            _counter++;
        }

        public virtual double beregnLøn() {
            return _basisLøn;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, MobilNr: {MobilNr}, Stilling: {Stilling}, AnsættelsesDato: {AnsættelsesDato} BasisLøn: {beregnLøn()}";
        }
    }
}
