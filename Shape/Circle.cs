public class Circle : Shape 
{  
    public Circle(string? color, bool filled) : base(color, filled)
    {

    }
    double Radius;

    public override double GetArea()
    {
      return ( Math.PI *(Radius*Radius));
    }

    public override double GetPerimetr()
    {
        return (2*Math.PI*Radius);
    }
}