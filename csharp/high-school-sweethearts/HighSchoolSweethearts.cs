using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
        => $"{studentA} ♡ {studentB}".PadLeft(32 + studentB.Length, ' ').PadRight(61, ' ');

    public static string DisplayBanner(string studentA, string studentB)
    {
        return @$"******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA} +  {studentB}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        return String.Format(new CultureInfo("de-DE"), $"{studentA} and {studentB} have been dating since {start.ToString("dd.MM.yyyy")} - that's {hours.ToString("N")} hours");
    }
}
