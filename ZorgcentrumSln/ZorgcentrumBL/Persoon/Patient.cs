namespace ZorgcentrumBL.Persoon;

public class Patient : Persoon {
    //IDEE: Superklasse Persoon maken met rijksregisterNr, naam, voornaam als properties waarvan patient en arts klassen van overerven

    public Patient(string rijksRegisterNr, string naam, string voornaam, Afdeling afdeling)
        : base(rijksRegisterNr, naam, voornaam,afdeling) {

    }
}
