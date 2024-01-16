using LinearAlgebra;

namespace TestProject1;

public class Tests
{
    
    [Test]
    public void Constructor_Empty()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[]"));
    }
    
    [Test]
    public void Constructor_WithList()
    {
        MathVector vector = new MathVector(new List<double>(){0,0,1});
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[0,0,1]"));
    }
    
    [Test]
    public void Constructor_WithListBackDoor()
    {
        List<double> list = new List<double>() { 0, 0, 1 };
        MathVector vector = new MathVector(list);
        list[0] = 2;
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[0,0,1]"));
    }
    
    [Test]
    public void Constructor_WithListNull()
    {
        List<double> list = new List<double>() {};
        MathVector vector = new MathVector(list);
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[]"));
    }
    
    [Test]
    public void Constructor_WithParams()
    {
        MathVector vector = new MathVector(0, 0, 2);
        Assert.That(vector.ToString(), Is.EqualTo("MathVector[0,0,2]"));
    }
    
    [Test]
    public void Method_Dimensions()
    {
        MathVector vector = new MathVector(0, 0, 2);
        Assert.That(vector.Dimensions, Is.EqualTo(3));
    }
    
    [Test]
    public void Method_DimensionsNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.Dimensions, Is.EqualTo(0));
    }
    
    [Test]
    public void Index_Get()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector[0], Is.EqualTo(1));
    }
    
    [Test]
    public void Index_GetOutOfRange()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            var _ = vector[3];
        });
    }
    
    [Test]
    public void Index_GetNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            var _ = vector[-1];
        });
    }
    
    [Test]
    public void Index_Set()
    {
        MathVector vector = new MathVector(1, 2, 3);
        vector[0] = 0;
        Assert.That(vector[0], Is.EqualTo(0));
    }
    
    [Test]
    public void Index_SetOutOfRange()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            vector[3] = 0;
        });
    }
    
    [Test]
    public void Index_SetNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<IndexOutOfRangeException>(() =>
        {
            vector[-1] = 0;
        });
    }
    
    [Test]
    public void Method_Length()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Length, Is.EqualTo(Math.Sqrt(1 * 1 + 2 * 2 + 3 * 3)));
    }
    
    [Test]
    public void Method_LengthNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.Length, Is.EqualTo(0));
    }
    
    [Test]
    public void Method_SumNumber()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.SumNumber(1), Is.EqualTo(new MathVector(2, 3, 4)));
    }
    
    [Test]
    public void Method_SumNumberNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.SumNumber(1), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SumNumberZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.SumNumber(0), Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SumNumberNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.SumNumber(-1), Is.EqualTo(new MathVector(0, 1, 2)));
    }
    
    [Test]
    public void Method_SumNumberNiggativeAndNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.SumNumber(-1), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyNumber()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.MultiplyNumber(2), Is.EqualTo(new MathVector(2, 4, 6)));
    }
    
    [Test]
    public void Method_MultiplyNumberNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.MultiplyNumber(2), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyNumberNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.MultiplyNumber(-2), Is.EqualTo(new MathVector(-2, -4, -6)));
    }
    
    [Test]
    public void Method_MultiplyNumberNiggativeAndNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.MultiplyNumber(-2), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyNumberZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.MultiplyNumber(0), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_Sum()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Sum(new MathVector(1, 2, 3)), Is.EqualTo(new MathVector(2, 4, 6)));
    }
    
    [Test]
    public void Method_SumNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.Sum(new MathVector()), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SumZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Sum(new MathVector(0, 0, 0)), Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SumNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Sum(new MathVector(-1, -2, -3)), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_SumZeroException()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            vector.Sum(new MathVector());
        });
    }
    
    [Test]
    public void Method_Multiply()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Multiply(new MathVector(1, 3, 3)), Is.EqualTo(new MathVector(1, 6, 9)));
    }
    
    [Test]
    public void Method_MultiplyNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.Multiply(new MathVector()), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Multiply(new MathVector(0, 0, 0)), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_MultiplyNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.Multiply(new MathVector(-1, -2, -3)), Is.EqualTo(new MathVector(-1, -4, -9)));
    }
    
    [Test]
    public void Method_MultiplyZeroException()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            vector.Multiply(new MathVector());
        });
    }
    
    [Test]
    public void Method_ScalarMultiply()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.ScalarMultiply(new MathVector(3, 2, 1)), Is.EqualTo(1 * 3 + 2 * 2 + 3 * 1));
    }
    
    [Test]
    public void Method_ScalarMultiplyNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.ScalarMultiply(new MathVector()), Is.EqualTo(0));
    }
    
    [Test]
    public void Method_ScalarMultiplyZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.ScalarMultiply(new MathVector(0, 0, 0)), Is.EqualTo(0));
    }
    
    [Test]
    public void Method_ScalarMultiplyNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector.ScalarMultiply(new MathVector(-1, -2, -3)), Is.EqualTo(-1 * 1 + -2 * 2 + -3 * 3));
    }
    
    [Test]
    public void Method_ScalarMultiplyZeroException()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            vector.ScalarMultiply(new MathVector());
        });
    }
    
    [Test]
    public void Method_CalcDistance()
    {
        MathVector vector = new MathVector(1, 2, 3);
        double result = Math.Sqrt(double.Pow(2 - 1, 2) + double.Pow(3 - 2, 2) + double.Pow(4 - 3, 2));
        
        Assert.That(vector.CalcDistance(new MathVector(2, 3, 4)), Is.EqualTo(result));
    }
    
    [Test]
    public void Method_CalcDistanceNull()
    {
        MathVector vector = new MathVector();
        Assert.That(vector.CalcDistance(new MathVector()), Is.EqualTo(0));
    }
    
    [Test]
    public void Method_CalcDistanceZero()
    {
        MathVector vector = new MathVector(1, 2, 3);
        double result = Math.Sqrt(double.Pow(0 - 1, 2) + double.Pow(0 - 2, 2) + double.Pow(0 - 3, 2));
        
        Assert.That(vector.CalcDistance(new MathVector(0, 0, 0)), Is.EqualTo(result));
    }
    
    [Test]
    public void Method_CalcDistanceNiggative()
    {
        MathVector vector = new MathVector(1, 2, 3);
        double result = Math.Sqrt(double.Pow(-1 - 1, 2) + double.Pow(-2 - 2, 2) + double.Pow(-3 - 3, 2));
        
        Assert.That(vector.CalcDistance(new MathVector(-1, -2, -3)), Is.EqualTo(result));
    }
    
    [Test]
    public void Method_CalcDistanceZeroException()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            vector.CalcDistance(new MathVector());
        });
    }
    
    [Test]
    public void Method_SumOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + new MathVector(1, 2, 3), Is.EqualTo(new MathVector(2, 4, 6)));
    }
    
    [Test]
    public void Method_SumNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector + new MathVector(), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SumZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + new MathVector(0, 0, 0), Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SumNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + new MathVector(-1, -2, -3), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_SumZeroExceptionOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            var _ = vector + new MathVector();
        });
    }
    
    [Test]
    public void Method_SumNumberOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + 1, Is.EqualTo(new MathVector(2, 3, 4)));
    }
    
    [Test]
    public void Method_SumNumberNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector + 1, Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SumNumberZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + 0, Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SumNumberNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector + -1, Is.EqualTo(new MathVector(0, 1, 2)));
    }
    
    [Test]
    public void Method_SumNumberNiggativeAndNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector + -1, Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SubVectorOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - new MathVector(1, 2, 3), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_SubVectorNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector - new MathVector(), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_SubVectorZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - new MathVector(0, 0, 0), Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SubVectorNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - new MathVector(-1, -2, -3), Is.EqualTo(new MathVector(2, 4, 6)));
    }
    
    [Test]
    public void Method_SubVectorNiggativeAndNullOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            var _ = vector - new MathVector();
        });
    }
    
    [Test]
    public void Method_SubVectorNumberOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - 1, Is.EqualTo(new MathVector(0, 1, 2)));
    }
    
    [Test]
    public void Method_SubVectorNumberZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - 0, Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_SubVectorNumberNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector - -1, Is.EqualTo(new MathVector(2, 3, 4)));
    }
    
    [Test]
    public void Method_MultiplyNumberOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * 2, Is.EqualTo(new MathVector(2, 4, 6)));
    }
    
    [Test]
    public void Method_MultiplyNumberNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector * 2, Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyNumberNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * -2, Is.EqualTo(new MathVector(-2, -4, -6)));
    }
    
    [Test]
    public void Method_MultiplyNumberNiggativeAndNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector * -2, Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyNumberZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * 0, Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_MultiplyOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * new MathVector(1, 3, 3), Is.EqualTo(new MathVector(1, 6, 9)));
    }
    
    [Test]
    public void Method_MultiplyNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector * new MathVector(), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_MultiplyZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * new MathVector(0, 0, 0), Is.EqualTo(new MathVector(0, 0, 0)));
    }
    
    [Test]
    public void Method_MultiplyNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector * new MathVector(-1, -2, -3), Is.EqualTo(new MathVector(-1, -4, -9)));
    }
    
    [Test]
    public void Method_MultiplyZeroExceptionOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            var _ = vector * new MathVector();
        });
    }
    
    [Test]
    public void Method_ScalarMultiplyOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector % new MathVector(3, 2, 1), Is.EqualTo(1 * 3 + 2 * 2 + 3 * 1));
    }
    
    [Test]
    public void Method_ScalarMultiplyNullOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector % new MathVector(), Is.EqualTo(0));
    }
    
    [Test]
    public void Method_ScalarMultiplyZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector % new MathVector(0, 0, 0), Is.EqualTo(0));
    }
    
    [Test]
    public void Method_ScalarMultiplyNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector % new MathVector(-1, -2, -3), Is.EqualTo(-1 * 1 + -2 * 2 + -3 * 3));
    }
    
    [Test]
    public void Method_ScalarMultiplyZeroExceptionOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            var _ = vector % new MathVector();
        });
    }
    
    [Test]
    public void Method_DivisionVectorOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector / new MathVector(1, 2, 3), Is.EqualTo(new MathVector(1, 1, 1)));
    }
    
    [Test]
    public void Method_DivisionVectorNullTwoOperator()
    {
        MathVector vector = new MathVector();
        Assert.That(vector / new MathVector(), Is.EqualTo(new MathVector()));
    }
    
    [Test]
    public void Method_DivisionVectorZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<DivideByZeroException>(() =>
        {
            var _ = vector / new MathVector(0, 0, 0);
        });
    }
    
    [Test]
    public void Method_DivisionVectorNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector / new MathVector(-1, -2, -3), Is.EqualTo(new MathVector(-1, -1, -1)));
    }
    
    [Test]
    public void Method_DivisionVectorNullOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<Exception>(() =>
        {
            var _ = vector / new MathVector();
        });
    }
    
    [Test]
    public void Method_DivisionNumberOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector / 1, Is.EqualTo(new MathVector(1, 2, 3)));
    }
    
    [Test]
    public void Method_DivisionNumberZeroOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.Throws<DivideByZeroException>(() =>
        {
            var _ = vector / 0;
        });
    }
    
    [Test]
    public void Method_DivisionNumberNiggativeOperator()
    {
        MathVector vector = new MathVector(1, 2, 3);
        Assert.That(vector / -1, Is.EqualTo(new MathVector(-1, -2, -3)));
    }
}
