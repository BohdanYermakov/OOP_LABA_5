public class Program
{
    public static void Main()
    {
        int? mode = ChooseMode();
        if (mode == null)
            return;

        bool isAdvancedMode = mode == 2;

        string[] menuOptions = new string[] { "Exit", "Add", "Sub", "Mul", "Div" };
        if (isAdvancedMode)
        {
            menuOptions = menuOptions
                .Concat(
                    new string[2]
                    {
                        "Convert Byte to KiloByte",
                        "Convert Celsius to Fahrenheit"
                    }
                )
                .ToArray();
        }
        IAdvanced advancedCalc = new AdvancedCalc();
        AbstCalc baseCalc = new Calculator();

        int option = 0;
        do
        {
            option = PrintAndProcessMenu(menuOptions);

            try
            {
                if (option < 0 || option > menuOptions.Length)
                {
                    throw new Exception("Undefined option!");
                }

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting program");
                        break;
                    case 5:
                        Console.Write("Enter Byte amount: ");
                        double amount = double.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine(
                            "Converted amount: {0:F2} KB",
                            advancedCalc.ByteToKB(amount)
                        );
                        break;
                    case 6:
                        Console.Write("Enter degree in Celsius : ");
                        double amount2 = double.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine(
                            "Converted amount: {0:F2} in Fahrenheit degree",
                            advancedCalc.CelsiusToFahrenheit(amount2)
                        );
                        break;
                    default:
                        // Base calculator functions
                        Console.WriteLine("Enter two numbers through ENTER");
                        baseCalc.Num1 = double.Parse(Console.ReadLine() ?? "");
                        baseCalc.Num2 = double.Parse(Console.ReadLine() ?? "");
                        double operationRes = 0;
                        switch (option)
                        {
                            case 1:
                                operationRes = baseCalc.Add();
                                break;
                            case 2:
                                operationRes = baseCalc.Sub();
                                break;
                            case 3:
                                operationRes = baseCalc.Mul();
                                break;
                            case 4:
                                operationRes = baseCalc.Div();
                                break;
                        }
                        Console.WriteLine("Operation result: {0}", operationRes);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error found: " + e.Message);
                Thread.Sleep(1000);
                continue;
            }

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        } while (option != 0);
    }

    public static int? ChooseMode()
    {
        int mode;
        do
        {
            mode = ChooseModeMenu();
            if (mode == 0)
                return null;

            if (mode != 1 && mode != 2)
            {
                Console.WriteLine("Choose calculator mode correctly!");
                Thread.Sleep(1000);
            }
        } while (mode != 1 && mode != 2);

        return mode;
    }

    public static int ChooseModeMenu()
    {
        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("\t  Choose Calculator mode");
        Console.WriteLine("\t0 - Exit");
        Console.WriteLine("\t1 - Base calculator");
        Console.WriteLine("\t2 - Advanced calculator");

        Console.WriteLine();
        Console.Write("Choose option: ");

        try
        {
            int option = int.Parse(Console.ReadLine() ?? "");

            return option >= 0 && option <= 2 ? option : -1;
        }
        catch (Exception)
        {
            return -1;
        }
    }

    public static int PrintAndProcessMenu(string[] options)
    {
        Console.Clear();
        Console.WriteLine();

        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"\t{i + 1} - {options[i]}");
        }

        Console.WriteLine();
        Console.Write("Choose option: ");

        try
        {
            string tmp = Console.ReadLine() ?? "";

            return int.Parse(tmp) - 1;
        }
        catch (Exception)
        {
            return -1;
        }
    }
}
