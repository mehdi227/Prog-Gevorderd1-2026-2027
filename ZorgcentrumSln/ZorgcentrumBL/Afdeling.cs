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


    private HashSet<Arts> _artsen;

    public HashSet<Arts> Artsen {
        get { return _artsen; }
        set { _artsen = value; }
    }

    private HashSet<Patient> _patienten;

    public HashSet<Patient> Patienten {
        get { return _patienten; }
        set { _patienten = value; }
    }

}
