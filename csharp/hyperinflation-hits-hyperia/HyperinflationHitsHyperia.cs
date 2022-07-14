using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {

        try
        {
            return checked(@base * multiplier).ToString();
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }
    public static string DisplayGDP(float @base, float multiplier)
    {
        try
        {
            var num = @base * multiplier;
            return num != float.PositiveInfinity ? num.ToString() : "*** Too Big ***";
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        decimal num = 0.1m;
        try
        {
            return checked(salaryBase * multiplier).ToString();
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
