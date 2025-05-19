string str = "Visual C# 程式設計範例教本";

// 方法 1: ToUpper() => 將字串轉為大寫
string upperStr = str.ToUpper();
Console.WriteLine(upperStr); 
// 結果: "VISUAL C# 程式設計範例教本"

// 方法 2: Substring(2, 4) => 從索引 2 開始，取 4 個字元
string substringStr = str.Substring(2, 4);
Console.WriteLine(substringStr);
// 結果: "sual"

// 方法 3: IndexOf("程式") => 找出 "程式" 在字串中的索引位置
int index = str.IndexOf("程式");
Console.WriteLine(index);
// 結果: 9