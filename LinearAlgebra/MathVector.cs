using System.Collections;
using IMathVectorLib;

namespace LinearAlgebra;

public class MathVector : IMathVector
{
    private List<double> Points;

    public MathVector(List<double> ls)
    {
        List<double> privatest = new List<double>(ls);
        Points = privatest;
    }
    
    public MathVector(params double[] points)
    {
        Points = new List<double>(points);
    }

    public int Dimensions => Points.Count;

    // Индекстор, [] не имеет перегрузки
    public double this[int i]
    {
        get
        { 
            if (i < 0 || Points.Count <= i)
                throw new IndexOutOfRangeException("Index of MathVector out of range");

            return Points[i];
        }
        set
        {
            if (i < 0 || Points.Count <= i)
                throw new IndexOutOfRangeException("Index of MathVector out of range");

            Points[i] = value;
        }
    }

    public double Length
    {
        get
        {
            var tmp = Points.Sum(num => Math.Pow(num, 2));
            return Math.Sqrt(tmp);
        }
    }

    public IMathVector SumNumber(double number)
    {
        var ls = new List<double>();
        foreach (var num in Points)
        {
            ls.Add(num + number);
        }
        return new MathVector(ls);
    }
    
    public IMathVector MultiplyNumber(double number)
    {
        var ls = new List<double>();
        foreach (var num in Points)
        {
            ls.Add(num * number);
        }
        return new MathVector(ls);
    }
    
    public IMathVector Sum(IMathVector vector)
    {
        if (vector.Dimensions != Dimensions)
            throw new Exception("Dimensions are not equal");
        
        var ls = new List<double>();
        for (var i = 0; i < Dimensions; i++)
        {
            ls.Add(vector[i] + this[i]);
        }
        return new MathVector(ls);
    }
    
    public IMathVector Multiply(IMathVector vector)
    {
        if (vector.Dimensions != Dimensions)
            throw new Exception("Dimensions are not equal");
        
        var ls = new List<double>();
        for (var i = 0; i < Dimensions; i++)
        {
            ls.Add(vector[i] * this[i]);
        }
        return new MathVector(ls);
    }

    public double ScalarMultiply(IMathVector vector)
    {
        if (vector.Dimensions != Dimensions)
            throw new Exception("Dimensions are not equal");
        
        var ls = new List<double>();
        for (var i = 0; i < Dimensions; i++)
        {
            ls.Add(vector[i] * this[i]);
        }
        return ls.Sum();
    }
    
    public double CalcDistance(IMathVector vector)
    {
        if (vector.Dimensions != Dimensions)
            throw new Exception("Dimensions are not equal");
        
        var ls = new List<double>();
        for (var i = 0; i < Dimensions; i++)
        {
            ls.Add(double.Pow(vector[i] - this[i], 2));
        }
        return Math.Sqrt(ls.Sum());
    }
    
    public static IMathVector operator +(MathVector vector1, IMathVector vector2)
    {
        return vector1.Sum(vector2);
    }
    
    public static IMathVector operator +(MathVector vector, double number)
    {
        return vector.SumNumber(number);
    }
    
    public static IMathVector operator -(MathVector vector1, IMathVector vector2)
    {
        if (vector1.Dimensions != vector2.Dimensions)
            throw new Exception("Dimensions are not equal");
        
        var ls = new List<double>();
        for (var i = 0; i < vector1.Dimensions; i++)
        {
            ls.Add(vector1[i] - vector2[i]);
        }
        return new MathVector(ls);
    }
    
    public static IMathVector operator -(MathVector vector, double number)
    {
        var ls = new List<double>();
        for (var i = 0; i < vector.Dimensions; i++)
        {
            ls.Add(vector[i] - number);
        }
        return new MathVector(ls);
    }
    
    public IEnumerator GetEnumerator()
    {
        return Points.GetEnumerator();
    }
    
    public static IMathVector operator *(MathVector vector, double number)
    {
        return vector.MultiplyNumber(number);
    }
    
    public static IMathVector operator *(MathVector vector1, IMathVector vector2)
    {
        return vector1.Multiply(vector2);
    }
    
    public static IMathVector operator /(MathVector vector, double number)
    {
        if (number == 0)
            throw new DivideByZeroException("Division by zero");

        var ls = new List<double>();
        for (var i = 0; i < vector.Dimensions; i++)
        {
            ls.Add(vector[i] / number);
        }
        return new MathVector(ls);
    }
    
    public static IMathVector operator /(MathVector vector1, IMathVector vector2)
    {
        if (vector1.Dimensions != vector2.Dimensions)
            throw new Exception("Dimensions are not equal");

        var ls = new List<double>();
        for (var i = 0; i < vector1.Dimensions; i++)
        {
            if (vector2[i] == 0)
                throw new DivideByZeroException("Division by zero");
            ls.Add(vector1[i] / vector2[i]);
        }
        return new MathVector(ls);
    }
    
    public static double operator %(MathVector vector1, IMathVector vector2)
    {
        return vector1.ScalarMultiply(vector2);
    }
    
    /// <summary>
    /// Возращает список из точек вектора в виде строки.
    /// </summary>
    /// <returns>MathVector[1,2,3,4].</returns>
    public override string ToString()
    {
        return $"MathVector[{string.Join(",", Points)}]";
    }
}