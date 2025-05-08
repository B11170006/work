using System;
using System.Linq;
using System.Windows.Forms;

public class MinMaxFinderApp : Form
{
    private TextBox[] inputBoxes = new TextBox[6]; // 用於輸入 6 個數字的文字框
    private Button calculateButton;
    private Label resultLabel;

    public MinMaxFinderApp()
    {
        // 設定視窗標題與大小
        this.Text = "最小值與最大值查找程式";
        this.Size = new System.Drawing.Size(400, 300);

        // 動態建立 6 個 TextBox 供使用者輸入數字
        for (int i = 0; i < inputBoxes.Length; i++)
        {
            inputBoxes[i] = new TextBox
            {
                Location = new System.Drawing.Point(50, 30 + (i * 30)),
                Width = 100
            };
            this.Controls.Add(inputBoxes[i]);
        }

        // 計算按鈕
        calculateButton = new Button
        {
            Text = "計算",
            Location = new System.Drawing.Point(200, 50),
            Width = 100
        };
        calculateButton.Click += CalculateButton_Click; // 設定按鈕點擊事件
        this.Controls.Add(calculateButton);

        // 顯示結果的標籤
        resultLabel = new Label
        {
            Text = "請輸入 6 個數字並按下計算。",
            Location = new System.Drawing.Point(50, 220),
            AutoSize = true
        };
        this.Controls.Add(resultLabel);
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        try
        {
            // 將使用者輸入的數字轉換為整數陣列
            int[] numbers = inputBoxes.Select(box => int.Parse(box.Text)).ToArray();

            // 使用 arrMin 和 arrMax 函數計算最小值與最大值
            int minValue = arrMin(numbers);
            int maxValue = arrMax(numbers);

            // 顯示結果
            resultLabel.Text = $"最小值: {minValue}, 最大值: {maxValue}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"輸入格式錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // 自訂函數: 傳回陣列的最小值
    private int arrMin(int[] array)
    {
        return array.Min(); // 使用 LINQ 的 Min 方法
    }

    // 自訂函數: 傳回陣列的最大值
    private int arrMax(int[] array)
    {
        return array.Max(); // 使用 LINQ 的 Max 方法
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MinMaxFinderApp());
    }
}