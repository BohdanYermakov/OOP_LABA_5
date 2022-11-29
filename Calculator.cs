
public class Calculator : AbstCalc
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }

    public override double Add()
    {
        return this.Num1 + this.Num2;
    }

    public override double Sub()
    {
        return this.Num1 - this.Num2;
    }

    public override double Div()
    {
        return this.Num1 / this.Num2;
    }

    public override double Mul()
    {
        return this.Num1 * this.Num2;
    }
}
