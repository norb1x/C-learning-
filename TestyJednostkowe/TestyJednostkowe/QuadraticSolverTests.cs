using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadraticSolver;  

namespace QuadraticSolver.Tests
{
    [TestClass]
    public class QuadraticSolverTests
    {
        [TestMethod]
        public void TestSolveQuadraticEquation_RealRoots()
        {
            string result = QuadraticSolver.SolveQuadraticEquation(1, -3, 2);  
            Assert.AreEqual("Root 1: 2, Root 2: 1", result);
        }

        [TestMethod]
        public void TestSolveQuadraticEquation_NoRealRoots()
        {
            string result = QuadraticSolver.SolveQuadraticEquation(1, 2, 5);  
            Assert.AreEqual("No real roots.", result);
        }
    }
}
