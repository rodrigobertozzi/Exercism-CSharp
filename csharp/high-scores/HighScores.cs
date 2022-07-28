using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> list;
    public HighScores(List<int> list) => this.list = list;

    public List<int> Scores() => list;

    public int Latest() => list.Last();

    public int PersonalBest() => list.OrderByDescending(x => x).First();

    public List<int> PersonalTopThree() => new List<int>(list.OrderByDescending(x => x).Take(3));
}