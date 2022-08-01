using System;

public class Robot
{
    public Robot() => Name = GenerateName();
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string name;

    public string GenerateName()
    {
        string randName = @"^[A-Z]{2}\d{3}$";
        Random rand = new Random();
        
        // I don't know how to implement this
    }

    public void Reset()
    {
        
    }
}