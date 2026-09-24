namespace WinkelkarProject.Model;

public class VoedingsProduct : Product {
    public VoedingsProduct(string omschrijving, double prijsPerStuk, Nutriscore nutriscore)
        : base(omschrijving, prijsPerStuk) {
        _nutriscore = nutriscore;
    }

    private Nutriscore _nutriscore;

    public Nutriscore Nutriscore {
        get { return _nutriscore; }
        init {
            //deze oplossing gevonden door Chat GPT
            if (!Enum.IsDefined(value)) throw new ArgumentException("De ingevoerde waarde is geen geldige nutriscore.");
            _nutriscore = value;
        }
    }

    public int BepaalKortingsPercentage() {
        return Nutriscore switch {
            Nutriscore.A => 30,
            Nutriscore.B => 25,
            Nutriscore.C => 15,
            Nutriscore.D => 5,
            Nutriscore.E => 0
        };
    }

    public override double GeefPrijsMetKorting() {
        double prijsMetKorting = 0;
        prijsMetKorting = this.PrijsPerStuk - this.BepaalKortingsPercentage();
        return prijsMetKorting;
    }
}
