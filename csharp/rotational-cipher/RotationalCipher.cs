using System;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char Rotate(char c)
        {
            if (!char.IsLetter(c))
                return c;
            int b = char.IsLower(c) ? 'a' : 'A';
            return (char)(b + ((c - b + shiftKey) % 26));
        }
        return string.Concat(text.Select(Rotate));

    }
}