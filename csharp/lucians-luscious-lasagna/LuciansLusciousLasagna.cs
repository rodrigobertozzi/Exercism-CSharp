using System;

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int remainingMinutesInOven) => 40 - remainingMinutesInOven;
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => layers * 2 + minutesInOven;

}
