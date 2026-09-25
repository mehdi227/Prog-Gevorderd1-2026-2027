namespace ZorgcentrumBL.Afspraak;

public abstract class Afspraak {
	private int _id;

	public int Id {
		get { return _id; }
		set { _id = value; }
	}

	private Type _type;
	public Type Type {
		get { return _type; }
		set { _type = value; }
	}

	private DateTime _datumTijdStart;

	public DateTime DatumTijdStart {
		get { return _datumTijdStart; }
		set { _datumTijdStart = value; }
	}

	private int _duurMin;

	public int DuurMin {
		get { return _duurMin; }
		set { _duurMin = value; }
	}

	private string _rijksRegisterNrPatient;

	public string RijksRegisterNrPatient {
		get { return _rijksRegisterNrPatient; }
		set { _rijksRegisterNrPatient = value; }
	}

    private string _rijksRegisterNrArts;

    public string RijksRegisterNrArts {
        get { return _rijksRegisterNrArts; }
        set { _rijksRegisterNrArts = value; }
    }

	private int _afdelingsCode;

	public int AfdelingsCode {
		get { return _afdelingsCode; }
		set { _afdelingsCode = value; }
	}


}
