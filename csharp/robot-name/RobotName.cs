using System;
using System.Collections.Generic;

public class Robot
{
    public Robot() => Reset();
    public string Name{ get; private set; }

    private static readonly HashSet<string> RobotNameTracker = new HashSet<string>();

    public string GenerateName()
    {
        Random random = new Random();
        var generateName = new char[5];

        for(var i = 0; i < 2; i++)
        {
            generateName[i] = (char)random.Next('A', 'Z' + 1);
        }

        for(var i = 2; i < 5; i++)
        {
            generateName[i] = (char)random.Next('0', '9' + 1);
        }
        return new string(generateName);
    }

    public string GenerateUniqueName()
    {
        var name = Name;

        while (!RobotNameTracker.Add(name))
            name = GenerateName();

        return name;
    }

    public void Reset() => Name = GenerateUniqueName();
}