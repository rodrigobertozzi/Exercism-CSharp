using System;

public class SpaceAge
{
    public int seconds;
    public SpaceAge(int seconds) => this.seconds = seconds;

    public double OnEarth() => TimeSpan.FromSeconds(seconds).TotalDays / 365.25;
    public double OnMercury() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 0.2408467;
    public double OnVenus() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 0.61519726;
    public double OnMars() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 1.8808158;
    public double OnJupiter() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 11.862615;
    public double OnSaturn() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 29.447498;
    public double OnUranus() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 84.016846;
    public double OnNeptune() => (TimeSpan.FromSeconds(seconds).TotalDays / 365.25) / 164.79132;
}