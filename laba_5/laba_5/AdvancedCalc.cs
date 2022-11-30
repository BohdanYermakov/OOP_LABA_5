
public class AdvancedCalc : Calculator, IAdvanced
{
    public double ByteToKB(double NumByte)
    {
        return NumByte / 1024;
    }

    public double CelsiusToFahrenheit(double Celsius)
    {
        return Celsius * 1.9 + 32;
    }
}