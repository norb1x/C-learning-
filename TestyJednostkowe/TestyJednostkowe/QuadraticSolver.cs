using System;  

namespace QuadraticSolver
{
    public class QuadraticSolver
    {
        public static string SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return "No real roots.";
            }
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);  
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);  
            return $"Root 1: {root1}, Root 2: {root2}";
        }
    }
}
