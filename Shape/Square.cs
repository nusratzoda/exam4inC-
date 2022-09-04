public class Square : Shape
{
    public Square(string? color, bool filled) : base(color, filled)
    {
    }

    public override double GetArea()
    {
        throw new NotImplementedException();
    }

    public override double GetPerimetr()
    {
        throw new NotImplementedException();
    }
     public override string? ToString()
    {
        return base.ToString;
    }
}