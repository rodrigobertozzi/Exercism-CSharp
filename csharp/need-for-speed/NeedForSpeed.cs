class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int battery;
    private int distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        battery = 100;
    }
    // TODO: define the constructor for the 'RemoteControlCar' class
    public bool BatteryDrained() => battery < batteryDrain;
    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (battery >= batteryDrain)
        {
            battery -= batteryDrain;
            distanceDriven += speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance) => this.distance = distance;
    // TODO: define the constructor for the 'RaceTrack' class

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();
        return car.DistanceDriven() >= distance;
    }
}
