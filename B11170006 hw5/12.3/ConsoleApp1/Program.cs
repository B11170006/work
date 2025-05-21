using System;

class Program
{
    // 委派宣告
    public delegate double ConvertToInches(double value);

    static void Main(string[] args)
    {
        Console.WriteLine("請輸入英尺(ft)：");
        double feet = double.Parse(Console.ReadLine() ?? "0");
        ConvertToInches converter = UnitConverter.FeetToInches;
        Console.WriteLine($"{feet} 英尺 = {converter(feet)} 英吋");

        Console.WriteLine("請輸入英碼(yd)：");
        double yards = double.Parse(Console.ReadLine() ?? "0");
        converter = UnitConverter.YardsToInches;
        Console.WriteLine($"{yards} 英碼 = {converter(yards)} 英吋");
    }
}