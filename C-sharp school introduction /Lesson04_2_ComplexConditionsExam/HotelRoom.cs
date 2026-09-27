namespace C_sharp_school_introduction.Lesson04_2_ComplexConditionsExam;

// Exam problem: Hotel Room
// Prices per night:
//   May and October:       studio 50,    apartment 65
//   June and September:    studio 75.20, apartment 68.70
//   July and August:       studio 76,    apartment 77
// Discounts:
//   studio, May/October, more than 7 nights: 5%;  more than 14 nights: 30%
//   studio, June/September, more than 14 nights: 20%
//   apartment, more than 14 nights, any month: 10%
// Read the month and the nights and print the price of the whole stay for both rooms.
public static class HotelRoom
{
    public static void Run()
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        var studioPrice = 0.0;
        var apartmentPrice = 0.0;

        if (month == "May" || month == "October")
        {
            studioPrice = 50;
            apartmentPrice = 65;
            if (nights > 14)
            {
                studioPrice = studioPrice * 0.70;
            }
            else if (nights > 7)
            {
                studioPrice = studioPrice * 0.95;
            }
        }
        else if (month == "June" || month == "September")
        {
            studioPrice = 75.20;
            apartmentPrice = 68.70;
            if (nights > 14)
            {
                studioPrice = studioPrice * 0.80;
            }
        }
        else if (month == "July" || month == "August")
        {
            studioPrice = 76;
            apartmentPrice = 77;
        }

        if (nights > 14)
        {
            apartmentPrice = apartmentPrice * 0.90;
        }

        Console.WriteLine($"Apartment: {apartmentPrice * nights:f2} lv.");
        Console.WriteLine($"Studio: {studioPrice * nights:f2} lv.");
    }
}
