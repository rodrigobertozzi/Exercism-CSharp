using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
        => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today()
        => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
        => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        int index = Array.IndexOf(birdsPerDay, 0);
        if (index > 0)
            return true;
        else
            return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birds = 0;
        for (int countDays = 0; countDays < numberOfDays; countDays++)
            birds = birds + birdsPerDay[countDays];
        return birds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int birds in birdsPerDay)
            if (birds >= 5)
                busyDays = busyDays + 1;
        return busyDays;
    }
}
