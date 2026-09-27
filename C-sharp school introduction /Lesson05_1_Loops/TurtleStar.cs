using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: * Draw a Star with the Turtle
// A green star with 5 beams. Repeat 5 times: go forward 200, turn 144 degrees.
public static class TurtleStar
{
    public static void Run()
    {
        Turtle.Reset();
        Turtle.PenColor = "green";

        for (int i = 0; i < 5; i++)
        {
            Turtle.Forward(200);
            Turtle.Rotate(144);
        }

        Turtle.ShowDrawing("turtle-star");
    }
}
