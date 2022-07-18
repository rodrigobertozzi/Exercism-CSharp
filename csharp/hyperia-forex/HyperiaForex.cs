using System;
using System.Diagnostics.CodeAnalysis;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? amount1.amount.Equals(amount2.amount) : throw new ArgumentException();
    public static bool operator !=(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? !amount1.amount.Equals(amount2.amount) : throw new ArgumentException();

    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? amount1.amount > amount2.amount : throw new ArgumentException();
    public static bool operator <(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? amount1.amount < amount2.amount : throw new ArgumentException();

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? new CurrencyAmount(amount1.amount + amount2.amount, amount1.currency) : throw new ArgumentException();
    public static CurrencyAmount operator -(CurrencyAmount amount1, CurrencyAmount amount2) => amount1.currency.Equals(amount2.currency) ? new CurrencyAmount(amount1.amount - amount2.amount, amount1.currency) : throw new ArgumentException();
    public static CurrencyAmount operator *(CurrencyAmount amount, decimal number) => new CurrencyAmount (amount.amount * number, amount.currency);
    public static CurrencyAmount operator /(CurrencyAmount amount, decimal number) => new CurrencyAmount(amount.amount / number, amount.currency);

    // TODO: implement type conversion operators
    public static implicit operator double(CurrencyAmount amount) => (double)amount.amount;
    public static implicit operator decimal(CurrencyAmount amount) => (decimal)amount.amount;

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            throw new ArgumentException();
        else
            return true;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(amount, currency);
    }
}
