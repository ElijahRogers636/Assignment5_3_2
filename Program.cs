

namespace Assignment5_3_2
{
    internal class Program
    {
        //You are climbing a staircase.
        //It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps. (2stepmax and 1stepmax)
        //In how many distinct ways can you climb to the top? (counter for the distinct ways)

        //Start out with first number as 0, and next number as 1 and use fib sequence


        static void Main(string[] args)
        {
            int steps = 10;
            Console.WriteLine($"Amount of unique combinations for { steps } steps: { ClimbStairs(steps) }");
        }

        static int ClimbStairs(int steps)
        {
            int prevprev = 0; // n-2 second to last amount of combinations
            int prev = 1; // n-1 prev amount of combinations
            int current = 0; //current amount of combinations
            for (int i = 0; i < steps; i++)
            {
                current = prevprev + prev; //Get current by addings prevprev and prev amount of combinations
                prevprev = prev;           // set the variable that holds the prevprev combination amount to the prev combination amount
                prev = current;            // set the prev variable to current amount
            }
            return current;
        }
    }
}
