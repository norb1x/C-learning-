using System; 

public class DivisionOperation : IMathOperation
{
    public double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Nie można dzielić przez 0.");
        }
        return num1 / num2;
    }
}
