namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Metric Converter
// Convert a distance between the units: m, mm, cm, mi, in, km, ft, yd.
// Read the number, the input unit and the output unit.
// Idea: first turn the number into meters, then turn the meters into the output unit.
public static class MetricConverter
{
    public static void Run()
    {
        var number = double.Parse(Console.ReadLine());
        var inputUnit = Console.ReadLine();
        var outputUnit = Console.ReadLine();

        // How many of each unit there are in 1 meter
        var mm = 1000;
        var cm = 100;
        var mi = 0.000621371192;
        var inches = 39.3700787;
        var km = 0.001;
        var ft = 3.2808399;
        var yd = 1.0936133;

        // Step 1: input unit -> meters
        var meters = number;
        if (inputUnit == "mm")
        {
            meters = number / mm;
        }
        else if (inputUnit == "cm")
        {
            meters = number / cm;
        }
        else if (inputUnit == "mi")
        {
            meters = number / mi;
        }
        else if (inputUnit == "in")
        {
            meters = number / inches;
        }
        else if (inputUnit == "km")
        {
            meters = number / km;
        }
        else if (inputUnit == "ft")
        {
            meters = number / ft;
        }
        else if (inputUnit == "yd")
        {
            meters = number / yd;
        }

        // Step 2: meters -> output unit
        var result = meters;
        if (outputUnit == "mm")
        {
            result = meters * mm;
        }
        else if (outputUnit == "cm")
        {
            result = meters * cm;
        }
        else if (outputUnit == "mi")
        {
            result = meters * mi;
        }
        else if (outputUnit == "in")
        {
            result = meters * inches;
        }
        else if (outputUnit == "km")
        {
            result = meters * km;
        }
        else if (outputUnit == "ft")
        {
            result = meters * ft;
        }
        else if (outputUnit == "yd")
        {
            result = meters * yd;
        }

        Console.WriteLine(result);
    }
}
