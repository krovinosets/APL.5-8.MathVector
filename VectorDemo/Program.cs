// See https://aka.ms/new-console-template for more information

namespace VectorDemo;

public static class Program
{
    public static void Main(string[] args)
    {
        Tests tests = new Tests();
        tests.TestBackDoor();
        tests.TestLen();
        tests.TestSum();
        tests.TestMin();
        tests.TestDiv();
        tests.TestIndex();
    }
}
