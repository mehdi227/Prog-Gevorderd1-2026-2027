using ZorgcentrumBL.Persoon;

namespace ZorgcentrumBL;

public class Afdeling {
    private int _id;

    public int Id {
        get { return _id; }
        set { _id = value; }
    }

    private string _naam;

    public string Naam {
        get { return _naam; }
        set { _naam = value; }
    }


    private List<Arts> _artsen;

    public List<Arts> Artsen {
        get { return _artsen; }
        set { _artsen = value; }
    }

    private List<Patient> _patienten;

    public List<Patient> Patienten {
        get { return _patienten; }
        set { _patienten = value; }
    }

}
