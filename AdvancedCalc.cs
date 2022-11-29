
public class AdvancedCalc : Calculator
{
    public double ByteToKB(double NumByte)
    {
        return NumByte / 1024;
    }

    public double CelsiusToFahrenheit(double Celsius)
    {
        return Celsius * 1.9 + 32;
    }

    public double Exp(double num)
    {
        return Math.Exp(num);
    }
}