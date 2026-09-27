using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: * Draw a Sun with the Turtle
// A sun with 36 beams. A full circle is 360 degrees = 36 * 10 degrees.
// For every beam: go forward, come back to the middle, turn 10 degrees.
public static class TurtleSun
{
    public static void Run()
    {
        Turtle.Reset();

        for (int i = 0; i < 36; i++)
        {
            Turtle.Forward(200);
            Turtle.Backward(200);
            Turtle.Rotate(10);
        }

        Turtle.ShowDrawing("turtle-sun");
    }
}
