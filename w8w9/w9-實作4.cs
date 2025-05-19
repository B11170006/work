using System;

public class PhoneList
{
    // 成員變數：儲存不同類型的電話
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    // 建構子：初始化電話資料
    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }

    // 方法：取得格式化的電話資訊
    public override string ToString()
    {
        return $"Home: {HomePhone}, Business: {BusinessPhone}, Cell: {CellPhone}";
    }
}

public class Cards
{
    // 成員變數：名片的基本資料
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public PhoneList Phone { get; set; }
    public string Email { get; set; }

    // 建構子：初始化名片資料
    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    // 方法：取得名片資料
    public string GetCard()
    {
        return $"Name: {Name}\nOccupation: {Occupation}\nAge: {Age}\nPhone: {Phone}\nEmail: {Email}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 建立 PhoneList 實例
        PhoneList phone = new PhoneList("02-1234-5678", "03-8765-4321", "0912-345-678");

        // 建立 Cards 實例
        Cards card = new Cards("John Doe", "Software Engineer", 30, phone, "john.doe@example.com");

        // 取得名片資料並輸出
        Console.WriteLine(card.GetCard());
    }
}