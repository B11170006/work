using System;

class Program
{
    static void Main(string[] args)
    {
        // 測試 Cube
        int x = 3;
        double y = 2.5;
        Console.WriteLine($"Cube({x}) = {MathUtil.Cube(x)}");
        Console.WriteLine($"Cube({y}) = {MathUtil.Cube(y)}");

        // 測試 MinElement
        int min3 = MathUtil.MinElement(8, 4, 5);
        int min4 = MathUtil.MinElement(9, 2, 7, 5);
        Console.WriteLine($"MinElement(8, 4, 5) = {min3}");
        Console.WriteLine($"MinElement(9, 2, 7, 5) = {min4}");
    }
}