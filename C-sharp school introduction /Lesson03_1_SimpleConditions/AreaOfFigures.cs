namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Areas of Figures
// Read a figure type (square, rectangle, circle or triangle) and its sizes.
// Print its area, rounded to 3 digits after the decimal point.
public static class AreaOfFigures
{
    public static void Run()
    {
        var figure = Console.ReadLine();
        var area = 0.0;

        if (figure == "square")
        {
            var side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure == "rectangle")
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            area = a * b;
        }
        else if (figure == "circle")
        {
            var radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
        }
        else if (figure == "triangle")
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            area = side * height / 2;
        }

        Console.WriteLine(Math.Round(area, 3));
    }
}
