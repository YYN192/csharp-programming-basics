using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: * Draw Spiral Triangles with the Turtle
// Three triangles, each made of 22 lines.
// Every line is 10 longer than the one before, and we turn 120 degrees after each line.
public static class TurtleSpiralTriangles
{
    public static void Run()
    {
        Turtle.Reset();
        Turtle.PenColor = "red";

        for (int triangle = 0; triangle < 3; triangle++)
        {
            for (int i = 1; i <= 22; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
        }

        Turtle.ShowDrawing("turtle-spiral-triangles");
    }
}
