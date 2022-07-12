using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return id switch
        {
            _ when id is null && department is not null => $"{name} - {department?.ToUpper()}",
            _ when department is null && id is not null => $"[{id}] - {name} - OWNER",
            _ when id is null && department is null => $"{name} - OWNER",
            _ => $"[{id}] - {name} - {department?.ToUpper()}"
        };
    }
}
