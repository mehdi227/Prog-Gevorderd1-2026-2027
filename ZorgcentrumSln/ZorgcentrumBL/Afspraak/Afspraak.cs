using ZorgcentrumBL.Persoon;

namespace ZorgcentrumBL.Afspraak;

public abstract class Afspraak {
    protected Afspraak(int id, string type, DateTime datumTijdStart, int duurMin, string rijksRegisterNrPatient, string rijksRegisterNrArts, int afdelingsCode) {
        Id = id;
        Type = type;
        DatumTijdStart = datumTijdStart;
        DuurMin = duurMin;
        RijksRegisterNrPatient = rijksRegisterNrPatient;
        RijksRegisterNrArts = rijksRegisterNrArts;
        AfdelingsCode = afdelingsCode;
    }

    private int _id;
    public int Id {
        get { return _id; }
        set { _id = value; }
    }

    private string _type;
    public string Type {
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

    private Patient _patient;
    public Patient Patient {
        get { return _patient; }
        set { _patient = value; }
    }

    private Arts _arts;
    public Arts Arts {
        get { return _arts; }
        set{ _arts = value; }
    }

    private Afdeling _afdeling;
    public Afdeling Afdeling {
        get { return _afdeling; }
        set { _afdeling = value; }
    }
}
