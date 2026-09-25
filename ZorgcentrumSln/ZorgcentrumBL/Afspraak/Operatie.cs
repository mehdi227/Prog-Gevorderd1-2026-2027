using System;
using System.Collections.Generic;
using System.Text;

namespace ZorgcentrumBL.Afspraak {
    public class Operatie : Afspraak {
        public Operatie(int id, string type, DateTime datumTijdStart, int duurMin, string rijksRegisterNrPatient, string rijksRegisterNrArts, int afdelingsCode) 
            : base(id, type, datumTijdStart, duurMin, rijksRegisterNrPatient, rijksRegisterNrArts, afdelingsCode) {
        }
    }
}
