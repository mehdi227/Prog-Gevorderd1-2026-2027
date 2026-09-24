using System;
using System.Collections.Generic;
using System.Text;

namespace WinkelkarProject.Model; 
public abstract class Product : IComparable<Product> {
    public Product(string omschrijving, double prijsPerStuk) {
        Omschrijving = omschrijving;
        PrijsPerStuk = prijsPerStuk;
    }

    private string _omschrijving;

	public string Omschrijving {
		get { return _omschrijving; }
		init {
			if (String.IsNullOrWhiteSpace(value)) throw new ArgumentException("De omschrijving mag niet leeg of NULL zijn.");
			_omschrijving = value;
		}
	}

	private double _prijsPerStuk;

    public double PrijsPerStuk {
		get { return _prijsPerStuk; }
		init {
			if (value < 0) throw new ArgumentException("Prijs per stuk moet positief of 0 zijn.");
			_prijsPerStuk = value;
		}
	}

	public double GeefPrijsZonderKorting() {
		return _prijsPerStuk;
	}
	public abstract double GeefPrijsMetKorting();

    public int CompareTo(Product? other) {
		return Omschrijving.CompareTo(other.Omschrijving);
    }
}
