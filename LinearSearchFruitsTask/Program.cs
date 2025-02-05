namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            Console.Write("Enter the fruit you want to find: ");
            string userInput = Console.ReadLine().ToLower();

            bool isFound = LinearSearch(fruits, userInput);

            Console.WriteLine(isFound);
        }

        static bool LinearSearch(string[] array, string target)
        {
            foreach (string item in array)
            {
                if (item == target)
                {
                    return true;
                }
            }
            return false;
        }
        }
    }
}
