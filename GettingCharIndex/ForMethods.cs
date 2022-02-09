using System;

namespace GettingCharIndex
{
    public static class ForMethods
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            // TODO #1. Analyze the implementation of "GetLastIndexOfChar(string, char)" method to see how "for" loop works, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            // TODO #2. Analyze the implementation of "GetLastIndexOfChar(string, char, int, int)" method to see how "for" loop works, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        public static int GetLastIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            for (int currentCharIndex = str.Length - 1; currentCharIndex >= 0; currentCharIndex--)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            for (int currentCharIndex = startIndex + count - 1; currentCharIndex >= startIndex; currentCharIndex--)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }
            }

            return -1;
        }
    }
}
