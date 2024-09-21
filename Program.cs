using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 5;
        double b = 7;
        double c = 4;

        double area = TriangleArea(a, b, c);

        Console.WriteLine($"Area of the triangle: {area}");
    }
    static double TriangleArea(double a, double b, double c)
    {

        double s = (a + b + c) / 2;

        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return area;
    }
}
