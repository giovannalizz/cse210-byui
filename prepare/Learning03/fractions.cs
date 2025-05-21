using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Fraction{

    private int _numer;
    private int _denom;

    public Fraction()
    { 
        _numer = 1;
        _denom = 1;

    }

    public Fraction(int whole)
    {
        _numer = whole;
        _denom = 1;

    }

    public Fraction(int numer, int denom)
    {
        _numer = numer;
        _denom = denom;
    }

    public string GetFractionString()
    {   
        string representation = $"{_numer} / {_denom}";
        return representation;

    }

    public double GetDecimalValue()
    {
        double value = (double)_numer / (double)_denom;
        return value;


    }

}