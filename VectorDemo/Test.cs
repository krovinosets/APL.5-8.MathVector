using LinearAlgebra;
using IMathVectorLib;

namespace VectorDemo;

public class Tests
{
    public void TestBackDoor()
    {
        Console.WriteLine("Тест 1");
        var lst = new List<double>() { 10, 10, 10 };
        IMathVector vec2 = new MathVector(lst);
        MathVector vector = new MathVector(1, 2, 3);
        Console.WriteLine(vector);
        var vec3 = vector + vec2;
        Console.WriteLine(vec3);
        lst[0] = 0;
        Console.WriteLine(vec2);
        Console.WriteLine(vector);
    }

    public void TestLen()
    {
        Console.WriteLine("Тест 2");
        MathVector vector = new MathVector(1, 2, 3);
        Console.WriteLine(vector);
        Console.WriteLine(vector.Dimensions);
        Console.WriteLine(vector.Length);
    }

    public void TestSum()
    {
        Console.WriteLine("Тест 3");
        MathVector vector1 = new MathVector(1, 2, 3);
        IMathVector vector2 = new MathVector(1, 2, 3);
        Console.WriteLine(vector1.SumNumber(1));
        Console.WriteLine(vector1.Sum(vector2));
        Console.WriteLine(vector1 + vector2);
    }

    public void TestMin()
    {
        Console.WriteLine("Тест 4");
        MathVector vector1 = new MathVector(1, 2, 3);
        IMathVector vector2 = new MathVector(1, 2, 3);
        Console.WriteLine(vector1.Multiply(vector2));
        Console.WriteLine(vector1.ScalarMultiply(vector2));
        Console.WriteLine(vector1 % vector2);
        Console.WriteLine(vector1.MultiplyNumber(5));
        Console.WriteLine(vector1 * vector2);
    }

    public void TestDiv()
    {
        Console.WriteLine("Тест 5");
        MathVector vector1 = new MathVector(1, 2, 3);
        IMathVector vector2 = new MathVector(1, 2, 3);
        IMathVector vector3 = new MathVector(1, 2);
        try
        {
            Console.WriteLine(vector1 + vector3);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        Console.WriteLine(vector1 - vector2);
        Console.WriteLine(vector1 / vector2);
        Console.WriteLine(vector1 / 1);
        Console.WriteLine(vector1 - 1);
        Console.WriteLine(vector1.CalcDistance(vector2));
    }

    public void TestIndex()
    {
        Console.WriteLine("Тест 6");
        MathVector vector = new MathVector(1, 2, 3);
        Console.WriteLine(vector[0]);
        Console.WriteLine(vector[1]);
        Console.WriteLine(vector[2]);
        try
        {
           double a = vector[3];
           Console.WriteLine(a);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }

        vector[0] = 99;
        Console.WriteLine(vector);
    }
}