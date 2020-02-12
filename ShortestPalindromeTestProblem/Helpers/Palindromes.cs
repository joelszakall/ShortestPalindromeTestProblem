namespace Helpers
{
    public static class Palindromes
    {

        static public int MinCharsRequiredForPalindrome(string str)
        {
            /*
             
            To find the least amount of characters required to make a palindrome from an existing string (only
            by adding characters to the beginning of the string), we first check if the string is a palindrome.
            If it is not palindrome, we remove 1 character at a time from the end of it then perform the check
            again. If it is a palindrome, that means for the original string to become a palindrome we would
            have to add the removed characters in their reversed order to the beginning of it.

            */

            int len = str.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (IsPalindrome(str, 0, i))
                {
                    return (len - i - 1);
                }
            }

            return 0;

        }

        static public bool IsPalindrome(string str, int startIndex, int endIndex, bool isCaseSensitive = false)
        {

            if (!isCaseSensitive)
                str.ToLower();

            // we compare each char within the the string and we compare it backwards until we find a mismatch
            while (startIndex < endIndex)
            {

                if (str[startIndex] != str[endIndex])
                {
                    // found a mismatch, therefore not a palindrome
                    return false;
                }

                startIndex++;
                endIndex--;
            }

            // if we made it this far, this means the word is a palindrome
            return true;

        }

        static public string ReverseString(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i].ToString();
            }

            return reversed;
        }

    }
}
