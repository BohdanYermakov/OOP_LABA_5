
public class Calculator : AbstCalc
{   
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
