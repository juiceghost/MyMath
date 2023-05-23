﻿namespace MathTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BasicRooterTest()
    {
        // Create an instance to test:
        Rooter rooter = new Rooter();
        // Define a test input and output value:
        double expectedResult = 2.0;
        double input = expectedResult * expectedResult;
        // Run the method under test:
        double actualResult = rooter.SquareRoot(input);
        // Verify the result:
        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
    }

    [TestMethod]
    public void RooterValueRange()
    {
        // Create an instance to test.
        Rooter rooter = new Rooter();

        // Try a range of values.
        for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
        {
            RooterOneValue(rooter, expected);
        }
    }

    private void RooterOneValue(Rooter rooter, double expectedResult)
    {
        double input = expectedResult * expectedResult;
        double actualResult = rooter.SquareRoot(input);
        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
    }

    [TestMethod]
    public void RooterTestNegativeInput()
    {
        Rooter rooter = new Rooter();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-1));
    }

}
