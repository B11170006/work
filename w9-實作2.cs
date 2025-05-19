using System;

public class Box
{
    // 成員變數
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }

    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 成員方法：計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 成員方法：計算表面積
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 建立 Box 物件
        Box box = new Box(3, 4, 5);

        // 顯示體積和面積
        Console.WriteLine($"盒子的體積: {box.Volume()}");
        Console.WriteLine($"盒子的表面積: {box.Area()}");
    }
}