using System;
using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
        => TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), GetTimeZoneInfo(location));

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
        => alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.AddHours(-1.75),
            AlertLevel.Late => appointment.AddMinutes(-30)
        };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo timeZoneInfo = GetTimeZoneInfo(location);
        return timeZoneInfo.IsDaylightSavingTime(dt) != timeZoneInfo.IsDaylightSavingTime(dt.AddDays(-7));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
        => DateTime.TryParse(dtStr, GetCultureInfo(location), DateTimeStyles.None, out var normalizeDateTime) ? normalizeDateTime : new(1, 1, 1);

    private static TimeZoneInfo GetTimeZoneInfo(Location location) => OperatingSystem.IsWindows() ? WindowsTimeZoneInfo(location) : LinuxAndMacTimeZoneInfo(location);
    private static TimeZoneInfo WindowsTimeZoneInfo(Location location) => location switch
    {
        Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
        Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
        Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time")
    };
    private static TimeZoneInfo LinuxAndMacTimeZoneInfo(Location location) => location switch
    {
        Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("America/New_York"),
        Location.London => TimeZoneInfo.FindSystemTimeZoneById("Europe/London"),
        Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris")
    };

    private static CultureInfo GetCultureInfo(Location location) => location switch
    {
        Location.NewYork => CultureInfo.GetCultureInfo("en-US"),
        Location.London => CultureInfo.GetCultureInfo("en-GB"),
        Location.Paris => CultureInfo.GetCultureInfo("fr-FR"),
    };
}



