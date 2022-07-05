using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var st = new StringBuilder();
        var foundDash = false;
        foreach (char c in identifier)
        {
            st.Append(c switch
            {
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when foundDash => char.ToUpperInvariant(c),
                _ when isGreek(c) => string.Empty,
                _ when char.IsLetter(c) => c,
                _ when char.IsDigit(c) => "",
                _ => string.Empty
            });
            foundDash = c.Equals('-');

        }

        return st.ToString();
    }
    private static bool isGreek(char c) => (c >= 'α' && c <= 'ω');

}
