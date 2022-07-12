namespace StraightLineLibrary
{
    


public struct Vector
{
    public double M { get; set; }
    public double N { get; set; }
    public double P { get; set; }

    public Vector(double m, double n, double p)
    {
        M = m;
        N = n;
        P = p;
    }
}
}