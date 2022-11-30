
public abstract class AbstCalc
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    
    public string? Model { get; protected set; }

    public abstract double Add();
    
    public abstract double Sub();

    public abstract double Div();

    public abstract double Mul();
}
