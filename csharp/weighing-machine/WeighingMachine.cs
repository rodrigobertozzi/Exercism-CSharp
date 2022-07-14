using System;
using System.Globalization;

class WeighingMachine
{
    public WeighingMachine(int precision) => this.Precision = precision;
    public int Precision { get; private set; }
    private double _weight;
    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value > 0)
                _weight = value;
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    public double TareAdjustment { get; set; } = 5;
    public string DisplayWeight
    {
        get { return String.Format(new NumberFormatInfo() { NumberDecimalDigits = Precision }, "{0:F} kg", this.Weight - this.TareAdjustment); }
    }

}
