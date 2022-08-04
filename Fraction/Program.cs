using System;

namespace FractionProg;

class Fraction
{
    private int _numerator { get; set; }
    private int _denominator { get; set; }

    public Fraction()
    {
        _numerator = 0;
        _denominator = 0;
    }

    public Fraction(int num, int denom)
    {
        _numerator=num;
        _denominator=denom;
    }

    public Fraction Multiply(in Fraction other)
    {
        Fraction f= new Fraction(_numerator* other._numerator, _denominator* other._denominator);
        return f;
       
    }
    public Fraction Divide(in Fraction other)
    {
        if (other._denominator != 0)
        {
            Fraction f = new Fraction(_numerator + other._numerator, _denominator + other._denominator);
            return f;
        }
        return this;
        
    }
    public Fraction Add(in Fraction other)
    {
        Fraction f = new Fraction(_numerator + other._numerator, _denominator + other._denominator);
        return f;
    }
    public Fraction Subtract(in Fraction other)
    {

         Fraction f= new Fraction(_numerator - other._numerator, _denominator - other._denominator);
         return f;
    }
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}


class FragtionProgram
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(10,5);
        Fraction fraction2 = new Fraction(5,0);
        //Console.WriteLine(fraction1.Add(fraction2).ToString());
        //Console.WriteLine(fraction1.Subtract(fraction2).ToString());
        //Console.WriteLine(fraction1.Multiply(fraction2).ToString());
        //Console.WriteLine(fraction1.Divide(fraction2).ToString());
    }
}

