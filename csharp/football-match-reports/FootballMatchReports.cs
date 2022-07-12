using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
                return "center back";
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
                return "midfielder";
            case 7:
                return "midfielder";
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                throw new ArgumentOutOfRangeException("Shirt number outside 1-11");
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return $"{report}";
            case Foul foul:
                return "The referee deemed a foul.";
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Incident incident:
                return incident.GetDescription();
            case Manager { Club: null } manager:
                return $"{manager.Name}";
            case Manager manager:
                return $"{manager.Name} ({manager.Club})";
            default:
                throw new ArgumentException("Not a int or an string");
        }
    }
}
