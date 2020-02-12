using System;
using Helpers;

namespace ShortestPalindromeTestProblem
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is the minimum amount of characters we need to append/prepend to make a string a palindrome?\n");
            Console.WriteLine("Let's find out!\n");
            Console.Write("Enter a single string containing no spaces: ");

            // we will assume the user doesn't care about case sensitivity for this example
            string word = Console.ReadLine().ToLower();

            //TODO: validation & reprompt if invalid, add option for case sensitivity option from user input

            int resultPrepend = Palindromes.MinCharsRequiredForPalindrome(word);
            int resultAppend = Palindromes.MinCharsRequiredForPalindrome(Palindromes.ReverseString(word));

            int requiredCharacters = (resultPrepend < resultAppend) ? resultPrepend : resultAppend;

            if (requiredCharacters == 0)
            {
                Console.WriteLine("No characters are needed because the entered word is already palindrome!");
            }
            else
            {
                Console.WriteLine("We need to prepend/append {0} characters for '{1}' to become a palindrome.", requiredCharacters, word);
            }

            //TODO: we could extend the granularity further, and tell the user how many characters, if we prepend or append, the string
            //      that is added to the original string, and the final palindrome

        }
    }
}
