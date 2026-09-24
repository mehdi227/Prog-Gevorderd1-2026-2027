namespace WinkelkarProject.Model;

public class VoedingsProduct : Product {
    public VoedingsProduct(string omschrijving, double prijsPerStuk, Nutriscore nutriscore)
        : base(omschrijving, prijsPerStuk) {

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
        int kortingsPercentage = 0;
        return kortingsPercentage switch {
            (int)Nutriscore.A => 30,
            (int)Nutriscore.B => 25,
            (int)Nutriscore.C => 15,
            (int)Nutriscore.D => 5,
            (int)Nutriscore.E => 0
        };
        //if (Nutriscore == Nutriscore.A) { kortingsPercentage = 30; }
        //else if (Nutriscore == Nutriscore.B) { kortingsPercentage = 25; }
        //else if (Nutriscore == Nutriscore.C) { kortingsPercentage = 15; }
        //else if (Nutriscore == Nutriscore.D) { kortingsPercentage = 5; }
        //else { kortingsPercentage = 0; }

        return kortingsPercentage;
    }

    public override double GeefPrijsMetKorting() {
        double prijsMetKorting = 0;
        prijsMetKorting = this.PrijsPerStuk - this.BepaalKortingsPercentage();
        return prijsMetKorting;
    }
}
