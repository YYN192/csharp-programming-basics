namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Lab: Ratings (a web app in the book)
// In the book this is an ASP.NET MVC web app that shows a rating (0 to 100) as 10 star pictures.
// Console version: read a rating from 0 to 100 and draw it with 10 stars:
// ★ = full star, ½ = half star, ☆ = empty star
public static class RatingsApp
{
    public static void Run()
    {
        var rating = int.Parse(Console.ReadLine());

        var fullStars = rating / 10;
        var emptyStars = (100 - rating) / 10;
        var halfStars = 10 - fullStars - emptyStars;

        var stars = "";
        for (int i = 0; i < fullStars; i++)
        {
            stars = stars + "★";
        }
        for (int i = 0; i < halfStars; i++)
        {
            stars = stars + "½";
        }
        for (int i = 0; i < emptyStars; i++)
        {
            stars = stars + "☆";
        }

        Console.WriteLine(stars);
    }
}
