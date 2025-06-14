using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using 期末報告;

namespace 視窗程式設計
{
    public partial class FormDiceGame : Form
    {
        private Random random = new Random();
        private string currentGuess = "";
        private Timer animationTimer;
        private int animationCount = 0;
        private int finalD1, finalD2, finalD3;
        private Image[] diceImages = new Image[6];

        public FormDiceGame()
        {
            InitializeComponent();
            this.ClientSize = new Size(600, 500);
            // 載入骰子圖檔：檔名格式為 dice1.png ~ dice6.png
            for (int i = 0; i < 6; i++)
            {
                string filePath = Path.Combine(Application.StartupPath, "dice" + (i + 1) + ".png");
                if (File.Exists(filePath))
                    diceImages[i] = Image.FromFile(filePath);
                else
                    MessageBox.Show("找不到檔案: " + filePath);
            }
            animationTimer = new Timer();
            animationTimer.Interval = 100;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        // 玩家點選「大」
        private void btnGuessBig_Click(object sender, EventArgs e)
        {
            currentGuess = "大";
            lblStatus.Text = "您選擇【大】，請點擊 [搖骰] 開始動畫。";
        }

        // 玩家點選「小」
        private void btnGuessSmall_Click(object sender, EventArgs e)
        {
            currentGuess = "小";
            lblStatus.Text = "您選擇【小】，請點擊 [搖骰] 開始動畫。";
        }

        // 點選「搖骰」以啟動動畫擲骰
        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentGuess))
            {
                MessageBox.Show("請先選擇【大】或【小】！");
                return;
            }
            btnRoll.Enabled = false;
            animationCount = 0;
            animationTimer.Start();
        }

        // Timer 每次更新三個 PictureBox 以模擬骰子滾動
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int d1 = random.Next(1, 7);
            int d2 = random.Next(1, 7);
            int d3 = random.Next(1, 7);
            pictureBox1.Image = diceImages[d1 - 1];
            pictureBox2.Image = diceImages[d2 - 1];
            pictureBox3.Image = diceImages[d3 - 1];
            animationCount++;
            if (animationCount >= 20)
            {
                animationTimer.Stop();
                finalD1 = random.Next(1, 7);
                finalD2 = random.Next(1, 7);
                finalD3 = random.Next(1, 7);
                pictureBox1.Image = diceImages[finalD1 - 1];
                pictureBox2.Image = diceImages[finalD2 - 1];
                pictureBox3.Image = diceImages[finalD3 - 1];
                int sum = finalD1 + finalD2 + finalD3;
                // 規則：總和大於9判定為「大」，否則為「小」
                string correct = sum > 9 ? "大" : "小";
                if (currentGuess == correct)
                {
                    MessageBox.Show("恭喜您猜對了！");
                    FormHistory.AddRecord("骰子比大小 - 贏");
                }
                else
                {
                    MessageBox.Show("很遺憾，猜錯了！");
                    FormHistory.AddRecord("骰子比大小 - 輸");
                }
                currentGuess = "";
                lblStatus.Text = "請重新選擇【大】或【小】，再點擊 [搖骰]。";
                btnRoll.Enabled = true;
            }
        }

        private void FormDiceGame_Load(object sender, EventArgs e)
        {

        }

        // 點選「回到大廳」按鈕返回主畫面
        private void btnBackToLobby_Click(object sender, EventArgs e)
        {
            FormIntro frmIntro = new FormIntro();
            frmIntro.Show();
            this.Hide();
        }

        // 點選「歷史紀錄」按鈕開啟歷史紀錄表單
        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory frmHistory = new FormHistory();
            frmHistory.Show();
        }
    }
}
