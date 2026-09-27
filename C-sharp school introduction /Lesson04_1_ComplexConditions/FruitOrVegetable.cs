namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Fruit or Vegetable
// Fruits: banana, apple, kiwi, cherry, lemon, grapes
// Vegetables: tomato, cucumber, pepper, carrot
// Print "fruit", "vegetable" or "unknown".
public static class FruitOrVegetable
{
    public static void Run()
    {
        var product = Console.ReadLine();

        if (product == "banana" || product == "apple" || product == "kiwi" ||
            product == "cherry" || product == "lemon" || product == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "tomato" || product == "cucumber" ||
                 product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
