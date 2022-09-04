public abstract class Shape
{
     string color;
    bool filledd = true;
    
    public  void shape(){}
    public Shape(string? color, bool filled)
    {
        this.color = color;
        this.filledd = filled;
    }
    public string GetColor(){
        return "white";
    }
    public void SetColor(string color){
        System.Console.WriteLine( "color");
    }
    public abstract double GetArea();
    public abstract double GetPerimetr();
    public string? ToString(){
        return "";
    }
}