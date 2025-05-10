public class MathCalculator
{
    private IMathOperation _operation;

    // Ustawienie operacji matematycznej
    public void SetOperation(IMathOperation operation)
    {
        _operation = operation;
    }

    // Wykonanie operacji matematycznej
    public double ExecuteOperation(double num1, double num2)
    {
        return _operation.Calculate(num1, num2);
    }
}
