public class Rectange : Shape
{
    double height;
    double length;
    public Rectange(string? color, bool filled, double height, double length) : base(color, filled)
    {
        this.height = height;
        this.length = length;
    }
    public override double GetArea()
    {
        return (height * length);
    }
    public override double GetPerimetr()
    {
        return (2 * (height + length));
    }
    public double GetHeight()
    {
        return height;
    }
    public void SetHeight(double height){
    } 
    public double GetLength()
    {
        return length;
    }
     public void SetLength(double length){
    } 
    public override string? ToString()
    {
        return base.ToString();
    }
}