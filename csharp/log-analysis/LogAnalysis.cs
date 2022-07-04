using System;
public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string delimiter) => log.Substring(log.IndexOf(delimiter) + delimiter.Length);
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string start, string end) => log[(log.IndexOf(start) + start.Length)..log.IndexOf(end)];
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log) => log.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}