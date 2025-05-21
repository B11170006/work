// Car 類別，實作 IPrice 介面
public class Car : IPrice
{
    public double Price { get; set; }
    public string Name { get; set; }

    public Car(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }

    public string GetName()
    {
        return Name;
    }
}