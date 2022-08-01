using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int _allergiesScores;
    public Allergies(int mask) => _allergiesScores = mask;
    public bool IsAllergicTo(Allergen allergen) => (_allergiesScores & (int)allergen) == (int)allergen;
    public Allergen[] List() => Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(value => IsAllergicTo(value)).ToArray();
}