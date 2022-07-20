using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        Coord1 = coord1;
        Coord2 = coord2;
        Coord3 = coord3;
        Coord4 = coord4;
    }
    public Coord Coord1 { get; }
    public Coord Coord2 { get; }
    public Coord Coord3 { get; }
    public Coord Coord4 { get; }
}

public class ClaimsHandler
{
    List<Plot> plots = new List<Plot>();
    public void StakeClaim(Plot plot)
    {
        if (IsClaimStaked(plot) == false)
            plots.Add(plot);
    }

    public bool IsClaimStaked(Plot plot) => plots.Contains(plot) ? true : false;
    public bool IsLastClaim(Plot plot) => plot.Equals(plots.Last());
    public Plot GetClaimWithLongestSide() => plots[0];
}
