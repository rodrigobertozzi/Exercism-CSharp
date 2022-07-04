using System;

class RemoteControlCar
{
    public int distanceDisplay = 0;
    public int batteryDisplay = 100;
    public static RemoteControlCar Buy()
    => new RemoteControlCar();

    public string DistanceDisplay()
        => $"Driven {distanceDisplay} meters";


    public string BatteryDisplay()
    {
        if (batteryDisplay == 0)
            return "Battery empty";
        else
            return $"Battery at {batteryDisplay}%";
    }

    public void Drive()
    {
        if (batteryDisplay == 0)
        {
            distanceDisplay = distanceDisplay + 0;
        }
        else
        {
            distanceDisplay = distanceDisplay + 20;
            batteryDisplay = batteryDisplay - 1;
        }
    }
}
