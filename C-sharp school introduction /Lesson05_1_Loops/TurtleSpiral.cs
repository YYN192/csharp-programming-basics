using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: * Draw a Spiral with the Turtle
// A spiral with 20 lines. Every line is a bit longer than the one before, and we turn 60 degrees.
public static class TurtleSpiral
{
    public static void Run()
    {
        Turtle.Reset();

        for (int i = 1; i <= 20; i++)
        {
            Turtle.Forward(i * 15);
            Turtle.Rotate(60);
        }

        Turtle.ShowDrawing("turtle-spiral");
    }
}
