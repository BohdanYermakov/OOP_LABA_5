
public abstract class AbstCalc
{
    public string Model { get; protected set; }

    public abstract double Add();

    public abstract double Sub();

    public abstract double Div();

    public abstract double Mul();
}
