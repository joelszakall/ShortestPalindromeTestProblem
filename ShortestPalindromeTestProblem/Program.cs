using System;

namespace ShortestPalindromeTestProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the minimum amount of characters we need to append/prepend to make a word a palindrome?");
            Console.Write("Enter a single string containing no spaces: ");
            string word = Console.ReadLine();

            int requiredCharacters = shortestPalindrome(word);

            if (requiredCharacters == 0)
            {
                Console.WriteLine("No characters are needed because the entered word is a palindrome!");
            }
            else
            {
                Console.WriteLine("The smallest number of characters to insert to become a palindrome is: {0}", requiredCharacters);
            }

        }


        //NOTE: I would typically use uppercase function names on all functions.
        //      Using lowercase to follow requested convention

        public static int shortestPalindrome(string str)
        {
            int len = str.Length;

            int resultPrepend = 0;
            int resultAppend = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                if (isPalindrome(str, 0, i))
                {
                    resultAppend = (len - i - 1);
                    break;
                }
            }

            for (int i = len - 1; i >= 0; i--)
            {
                if (isPalindrome(reverseString(str), 0, i))
                {
                    resultPrepend = (len - i - 1);
                    break;
                }
            }

            return (resultPrepend < resultAppend) ? resultPrepend : resultAppend;
        }

        private static bool isPalindrome(string s, int startIndex, int endIndex)
        {

            // ensure the string is lower-case
            string str = s.ToLower();

            // we compare each char within the the string and we compare it backwards until we reach the center
            // or until we find a mismatch
            while (startIndex < endIndex)
            {

                if (str[startIndex] != str[endIndex])
                {
                    return false;
                }

                startIndex++;
                endIndex--;
            }

            return true;

        }

        private static string reverseString(string s)
        {
            if (s.Length <= 1)
                return s;

            string reversed = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed += s[i].ToString();
            }

            return reversed;
        }
    }
}
