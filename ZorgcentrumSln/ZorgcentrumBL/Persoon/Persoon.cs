namespace ZorgcentrumBL.Persoon;

public abstract class Persoon {

    protected Persoon(string rijksRegisterNr, string naam, string voorNaam, Afdeling afdeling) {
        RijksRegisterNr = rijksRegisterNr;
        Naam = naam;
        VoorNaam = voorNaam;
        Afdeling = afdeling;
    }

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

    private Afdeling _afdeling;

    public Afdeling Afdeling {
        get { return _afdeling; }
        set { _afdeling = value; }
    }

}
