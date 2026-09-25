namespace ZorgcentrumBL.Persoon;

public class Arts : Persoon {
    public Arts(string rijksRegisterNr, string naam, string voornaam, Afdeling afdeling, string rizivNr)
        : base(rijksRegisterNr, naam, voornaam, afdeling) {
        RizivNr = rizivNr;
    }
    private string _rizivNr;

    public string RizivNr {
        get { return _rizivNr; }
        set { _rizivNr = value; }
    }
}
