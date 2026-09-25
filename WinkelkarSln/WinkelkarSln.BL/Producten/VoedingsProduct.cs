using System.ComponentModel.Design;
using WinkelkarProject.BuildingBlocks.Results;

namespace WinkelkarSln.BL.Producten;

public class VoedingsProduct : Product
{
    public Nutriscore Nutriscore { get; }

    private VoedingsProduct(string omschrijving, double prijsPerStuk, Nutriscore nutriscore) 
        : base(omschrijving, prijsPerStuk)
    {
        Nutriscore = nutriscore;
    }

    public static Result<VoedingsProduct> Create(string omschrijving, double prijsPerStuk, char nutriscore)
    {
        List<Error> errors = new List<Error>();

        errors.AddRange(Product.GetValidationErrors(omschrijving, prijsPerStuk));

        if (!Enum.TryParse<Nutriscore>(nutriscore.ToString(), true, out Nutriscore ouput))
        {
            errors.Add(Error.Create("De nutriscore is onbekend."));
        }

        if (errors.Any())
        {
            return Result<VoedingsProduct>.Failure(errors);
        }

        return Result<VoedingsProduct>.Success(new VoedingsProduct(omschrijving, prijsPerStuk, ouput));
    }

    public override double GeefPrijsMetKorting()
    {
        return GeefPrijsZonderKorting() * (1 - BepaalKortingsPercentage() / 100.0);
    }

    private int BepaalKortingsPercentage()
    {
        

        return Nutriscore switch
        {
            Nutriscore.A => 30,
            Nutriscore.B => 25,
            Nutriscore.C => 15,
            Nutriscore.D => 5,
            Nutriscore.E => 0,
            _ => throw new NotImplementedException()
        };
    }
}
