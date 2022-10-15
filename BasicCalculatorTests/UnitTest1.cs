using System.Collections.Generic;

namespace BasicCalculatorTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]

    [DataRow(1, 2, 3)]
    [DataRow(1, 1, 2)]
    [DataRow(3, 8, 11)]
    [DataRow(2, 2, 4)]
    [DataRow(3, 3, 6)]
    [DataRow(4, 1 , 5)]
    [DataRow(9 , 6.7 , 15.7)]
    [DataRow(1.2, 1, 2.2)]
    [DataRow(1.2, 1.7, 2.9)]
    [DataRow(5.3, 1, 6.3)]

    public void AdditionTest(double left, double right, double expected)
    {
        var result = BasicCalculator.CalculatorLogic.Addition(left, right);
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    [DataRow(2, 1, 1)]
    [DataRow(9, 2, 7)]
    [DataRow(10, 1, 9)]
    [DataRow(2.1, 1, 1.1)]
    [DataRow(9, -8, 17)]
    [DataRow(7.8, 1, 6.8)]
    [DataRow(6, 1, 5)]
    [DataRow(10, 9, 1)]
    [DataRow(4, 1, 3)]
    [DataRow(8, 1, 7)]

    public void SubtractionTest(double left, double right, double expected)
    {
        var result = BasicCalculator.CalculatorLogic.Substraction(left, right);
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    [DataRow(1, 2, 2)]
    [DataRow(8, 2, 16)]
    [DataRow(2, 9, 18)]
    [DataRow(1.2, 2, 2.4)]
    [DataRow(1.1, 9, 9.9)]
    [DataRow(-1, -2, 2)]
    [DataRow(9, -6, 54)]
    [DataRow(1.7, 8.9, 15.13)]
    [DataRow(7.9, -8.2, -64.78)]
    [DataRow(5, -5, -25)]

    public void MultiplicationTest(double left, double right, double expected)
    {
        var result = BasicCalculator.CalculatorLogic.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(9, 3, 3)]
    [DataRow(4, 4, 1)]
    [DataRow(3, 3, 1)]
    [DataRow(-9.9, 3, 3.3)]
    [DataRow(10, -5, -2)]
    [DataRow(6, -2, -3)]
    [DataRow(20, -5, -4)]
    [DataRow(8.9, 5, 1.78)]
    [DataRow(20, 10, 2)]
    [DataRow(-12, 4, -3)]

    public void DivisionTest(double left, double right, double expected)
    {
        var result = BasicCalculator.CalculatorLogic.Division(left, right);
        Assert.AreEqual(expected, result);
    }


    [TestMethod]

    public void TestDivideByZeroException()
    {

        Assert.ThrowsException<DivideByZeroException>(() => BasicCalculator.CalculatorLogic.Division(2, 0));
    }

    
}
