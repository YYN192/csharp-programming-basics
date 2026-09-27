using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: * Draw a Hexagon with the Turtle
// Repeat 6 times: turn 60 degrees, go forward 100.
public static class TurtleHexagon
{
    public static void Run()
    {
        Turtle.Reset();

        for (int i = 0; i < 6; i++)
        {
            Turtle.Rotate(60);
            Turtle.Forward(100);
        }

        Turtle.ShowDrawing("turtle-hexagon");
    }
}
