using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgcentrumBL.Afspraak {
    public class Consultatie : Afspraak {
        public Consultatie(int id, string type, DateTime datumTijdStart, int duurMin, string rijksRegisterNrPatient, string rijksRegisterNrArts, int afdelingsCode)
            : base(id, type, datumTijdStart, duurMin, rijksRegisterNrPatient, rijksRegisterNrArts, afdelingsCode) {
            if (duurMin < 10) throw new ArgumentException("Een Consultatie heeft een duur ≥ 10 minuten.");
        }
    }
}
