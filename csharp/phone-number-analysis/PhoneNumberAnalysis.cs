using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] analyseNumber = phoneNumber.Split('-');
        return (analyseNumber[0] == "212", analyseNumber[1] == "555", analyseNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        => phoneNumberInfo.IsFake == true;
}
