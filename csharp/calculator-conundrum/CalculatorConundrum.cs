using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        return (operation switch
        {
            _ when operation == "+" => $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
            _ when operation == "*" => $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
            _ when operation == "/" => operand2 != 0 ? $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}"
                : "Division by zero is not allowed.",
            _ when operation == "" => throw new ArgumentException(),
            _ when operation is null => throw new ArgumentNullException(),
            _ => throw new ArgumentOutOfRangeException(),
        });

    }
}
