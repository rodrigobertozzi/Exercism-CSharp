using System;
using System.Linq;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text)
        => new Regex(@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]").IsMatch(text);

    public string[] SplitLogLine(string text)
        => new Regex(@"<[\^*=-]+>").Split(text);

    public int CountQuotedPasswords(string lines)
        => new Regex("\\\".*password.*\\\"", RegexOptions.IgnoreCase).Matches(lines).Count;

    public string RemoveEndOfLineText(string line)
        => new Regex(@"end-of-line\d*").Replace(line, "");

    public string[] ListLinesWithPasswords(string[] lines)
        => lines.Select(l => l switch
        {
            string line when Regex.IsMatch(line, @"(?i)password[^ ]+") => $"{Regex.Match(line, @"(?i)password[^ ]+").Value}: {line}",
            _ => $"--------: {l}"
        }).ToArray();
}
