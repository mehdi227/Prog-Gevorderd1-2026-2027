namespace ZorgcentrumBL.Persoon;

public abstract class Persoon {

    protected Persoon(string rijksRegisterNr, string naam, string voorNaam, HashSet<Afdeling> afdelingen) {
        RijksRegisterNr = rijksRegisterNr;
        Naam = naam;
        VoorNaam = voorNaam;
        Afdelingen = afdelingen;
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

    private HashSet<Afdeling> _afdelingen;

    public HashSet<Afdeling> Afdelingen {
        get { return _afdelingen; }
        set { _afdelingen = value; }
    }

}
