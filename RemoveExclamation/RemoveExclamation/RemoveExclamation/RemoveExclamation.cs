using System;

namespace RemoveExclamation
{
    public class Remove
    {
        public static string RemoveLastExclamationMark(string input)
        {
            //Remove a exclamation mark from the end of string.
            return input[input.Length-1] == '!' ? input.Remove(input.Length - 1) : input;

        }
    }
}
