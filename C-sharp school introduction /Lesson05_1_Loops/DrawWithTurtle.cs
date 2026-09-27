using C_sharp_school_introduction.Helpers;

namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Lab: Drawing with a Turtle
// The turtle starts in the middle, looking up. We tell it where to go and it draws lines.
// Here we draw a triangle 4 times, like pressing the [Draw] button 4 times in the book's app.
public static class DrawWithTurtle
{
    public static void Run()
    {
        Turtle.Reset();

        for (int i = 0; i < 4; i++)
        {
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
        }

        Turtle.ShowDrawing("turtle-triangles");
    }
}
