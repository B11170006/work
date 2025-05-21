using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", 800000);
        Console.WriteLine("車名: " + car.GetName());
        Console.WriteLine("價格: " + car.GetPrice());
    }
}