using System;
using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var dialogCodes = new Dictionary<int, string>()
        {
            [1] = "United States of America",
            [55] = "Brazil",
            [91] = "India"
        };
        return dialogCodes;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dialogCodes = new Dictionary<int, string>();
        dialogCodes.Add(countryCode, countryName);
        return dialogCodes;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
            return existingDictionary[countryCode];
        else
            return string.Empty;
    }
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
            existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count == 0)
            return string.Empty;

        var longestString = existingDictionary.OrderByDescending(s => s.Value.Length).First();
        return longestString.Value.ToString();
    }
}