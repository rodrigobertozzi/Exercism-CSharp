public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    private Speed currentSpeed;
    public CarTelemetry Telemetry { get; }

    public RemoteControlCar() => Telemetry = new CarTelemetry(this);
    public string GetSpeed() => currentSpeed.ToString();
    public void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;
    public void SetSpeed(Speed speed) => currentSpeed = speed;
}

public class CarTelemetry
{
    private RemoteControlCar _remoteControlCar;
    public CarTelemetry(RemoteControlCar remoteControlCar) => _remoteControlCar = remoteControlCar;
    public void Calibrate() { }
    public bool SelfTest() => true;
    public void ShowSponsor(string sponsorName) => _remoteControlCar.SetSponsor(sponsorName);
    public void SetSpeed(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
        if (unitsString == "cps")
            speedUnits = SpeedUnits.CentimetersPerSecond;
        _remoteControlCar.SetSpeed(new Speed(amount, speedUnits));
    }
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}

public struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }
    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            unitsString = "centimeters per second";
        return Amount + " " + unitsString;
    }
}
