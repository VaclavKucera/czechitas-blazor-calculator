public class Calculator
{
    public double AktualniVysledek = 0;

    public void Secti(double b)
    {
        AktualniVysledek = AktualniVysledek + b;
    }

    public void Odecti(double b)
    {
        AktualniVysledek = AktualniVysledek - b;
    }

    public void Nasob(double b)
    {
        AktualniVysledek = AktualniVysledek * b;
    }

    public void Vydel(double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        AktualniVysledek =  AktualniVysledek / b;
    }

    public double VratAktualniVysledek()
    {
        return AktualniVysledek;
    }

    public void NastavAktualniVysledek(double novyVysledek)
    {
        AktualniVysledek = novyVysledek;
    }
}