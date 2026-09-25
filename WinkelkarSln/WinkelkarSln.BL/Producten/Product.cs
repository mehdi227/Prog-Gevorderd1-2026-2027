using WinkelkarProject.BuildingBlocks.Results;

namespace WinkelkarSln.BL.Producten;

public abstract class Product : IComparable<Product>
{
    
    public String Omschrijving { get; }
    private double PrijsPerStuk { get; }

    protected Product(string omschrijving, double prijsPerStuk)
    {       
        Omschrijving = omschrijving;
        PrijsPerStuk = prijsPerStuk;
    }

    public static List<Error> GetValidationErrors(string omschrijving, double prijsPerStuk)
    {
        List<Error> errors = new List<Error>();

        if (String.IsNullOrWhiteSpace(omschrijving))
        {
            errors.Add(Error.Create("De omschrijving mag niet leeg zijn."));
        }

        if (prijsPerStuk < 0)
        {
            errors.Add(Error.Create("Prijs per stuk moet 0 of positief zijn."));
        }

        return errors;
    }

    public double GeefPrijsZonderKorting()
    {
        return PrijsPerStuk;
    }

    public int CompareTo(Product other)
    {
        return Omschrijving.CompareTo(other.Omschrijving);
    }

    public abstract double GeefPrijsMetKorting();

    public override string? ToString()
    {
        return $"{Omschrijving} - {PrijsPerStuk:F2} euro";
    }
}
