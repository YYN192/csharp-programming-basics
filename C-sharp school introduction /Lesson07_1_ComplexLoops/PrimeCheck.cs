namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Prime Number Check (break)
// Read n and print "Prime" or "Not prime".
// A prime number is bigger than 1 and can be divided only by 1 and by itself.
// It is enough to check the divisors from 2 up to the square root of n.
public static class PrimeCheck
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var isPrime = n > 1;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;  // we found a divisor, no need to check more
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}
