using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgcentrumBL {
    public class Arts {
		private string _rijksRegisterNr;

		public string RijksRegisterNr {
			get { return _rijksRegisterNr; }
			set { _rijksRegisterNr = value; }
		}

		private string _naam;

		public string Naam {
			get { return _naam; }
			set { _naam = value; }
		}

		private string _voorNaam;

		public string VoorNaam {
			get { return _voorNaam; }
			set { _voorNaam = value; }
		}

		private string _rizivNr;

		public string RizivNr {
			get { return _rizivNr; }
			set { _rizivNr = value; }
		}

		private string _afdeling;

		public string Afdeling {
			get { return _afdeling; }
			set { _afdeling = value; }
		}


	}
}
