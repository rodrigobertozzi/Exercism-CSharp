using System;

abstract class Character
{
    string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
        => false;

    public override string ToString()
        => $"Character is a {characterType}";
}

class Warrior : Character
{

    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
        => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    public bool wasSpellPrepared;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (wasSpellPrepared is true)
            return 12;
        else
            return 3;
    }

    public void PrepareSpell()
        => wasSpellPrepared = true;

    public override bool Vulnerable()
    {
        if (wasSpellPrepared is true)
            return false;
        else
            return true;
    }
}
