using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length.Equals(secondStrand.Length) && firstStrand is not null && secondStrand is not null)
        {
            char[] firstStrandArray = firstStrand.ToCharArray();
            char[] secondStrandArray = secondStrand.ToCharArray();
            return firstStrandArray.Zip(secondStrandArray, (i, j) => i == j).Count(eq => !eq);
        }
        else
            throw new ArgumentException();
    }
}