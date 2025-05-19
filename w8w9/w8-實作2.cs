using System;
using System.Linq;
using System.Windows.Forms;

public class RandomArraySortingApp : Form
{
    private Label resultLabel;

    public RandomArraySortingApp()
    {
        // 初始化視窗
        this.Text = "亂數陣列排序展示";
        this.Size = new System.Drawing.Size(400, 200);

        // 初始化標籤控制項
        resultLabel = new Label
        {
            AutoSize = true,
            Location = new System.Drawing.Point(20, 20),
            Font = new System.Drawing.Font("Arial", 12)
        };
        this.Controls.Add(resultLabel);

        // 呼叫方法生成並顯示排序後的陣列
        DisplaySortedArray();
    }

    private void DisplaySortedArray()
    {
        // 宣告一維陣列
        int[] array = new int[5];

        // 使用亂數類別填充陣列
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 201); // 產生 1~200 範圍內的亂數
        }

        // 將陣列排序
        Array.Sort(array);

        // 將陣列內容轉換為字串並顯示在標籤上
        resultLabel.Text = "排序後的陣列內容: " + string.Join(", ", array);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new RandomArraySortingApp());
    }
}