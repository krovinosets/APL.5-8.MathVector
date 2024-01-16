using LinearAlgebra;

namespace UnitTest;

public class test
{
    [Test]
    public void Constructor_Empty()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[]"));
    }
}