using WinkelkarProject.BuildingBlocks.Results;
using WinkelkarProject.BuildingBlocks.ValueObjects;

namespace WinkelkarProject.Domein.Producten;

public class NietVoedingsProduct : Product
{
	public Percentage KortingsPercentage { get; }

	private NietVoedingsProduct(string omschrijving, double prijsPerStuk, Percentage kortingspercentage) 
		: base(omschrijving, prijsPerStuk)
    {
		KortingsPercentage = kortingspercentage;
    }

	public static Result<NietVoedingsProduct> Create(string omschrijving, double prijsPerStuk, double kortingspercentage)
	{
		List<Error> errors = new();

		errors.AddRange(Product.GetValidationErrors(omschrijving,prijsPerStuk));

		Result<Percentage> percentageResult = Percentage.Create(kortingspercentage);

        errors.AddRange(percentageResult.Errors);

        if (errors.Any())
		{
			return Result<NietVoedingsProduct>.Failure(errors);
		}

		return Result<NietVoedingsProduct>.Success(new NietVoedingsProduct(omschrijving, prijsPerStuk, percentageResult.Value));

    }

    public override double GeefPrijsMetKorting()
    {
		return GeefPrijsZonderKorting() * (1 - KortingsPercentage / 100.0);
    }
}
