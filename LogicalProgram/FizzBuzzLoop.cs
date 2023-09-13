namespace LogicalProgram
{
    public class FizzBuzzLoop
    {
        //Write a program that prints the numbers from 1 to 100.
        //But for multiples of 3, print "Fizz" instead of the number, 
        //and for the multiples of 5, print "Buzz." 
        //For numbers that are multiples of both 3 and 5, print "FizzBuzz."

        static List<string> FizzBuzz(int n)
        {
            // Declare a list of strings to store the results
            List<string> result = new List<string>();

            // Loop from 1 to n (inclusive)
            for (int i = 1; i <= n; ++i)
            {
                // Check if i is divisible by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    // Add "FizzBuzz" to the result list
                    result.Add("FizzBuzz");
                }
                // Check if i is divisible by 3
                else if (i % 3 == 0)
                {
                    // Add "Fizz" to the result list
                    result.Add("Fizz");
                }
                // Check if i is divisible by 5
                else if (i % 5 == 0)
                {
                    // Add "Buzz" to the result list
                    result.Add("Buzz");
                }
                else
                {
                    // Add the current number as a string to the
                    // result list
                    result.Add(i.ToString());
                }
            }
            // Return the result list
            return result;
        }

        static void Main(string[] args)
        {
            int n = 20;

            // Call the FizzBuzz function to get the result
            List<string> result = FizzBuzz(n);

            // Print the result
            foreach (string s in result)
            {
                Console.Write(s + " ");
            }
        }
    }
 
}
