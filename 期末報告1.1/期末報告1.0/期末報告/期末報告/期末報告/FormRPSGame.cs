using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 視窗程式設計
{
    public partial class FormRPSGame : Form
    {
        private int winCount = 0, lossCount = 0, drawCount = 0;
        private Random random = new Random();
        private Image scissorsImage, rockImage, paperImage;

        public FormRPSGame()
        {
            InitializeComponent();
            LoadImages();
            UpdateRecord();
        }

        // 載入遊戲所需圖片，請確保圖片檔存在於執行檔目錄下
        private void LoadImages()
        {
            string basePath = Application.StartupPath;
            string scissorsPath = Path.Combine(basePath, "scissors.png");
            string rockPath = Path.Combine(basePath, "rock.png");
            string paperPath = Path.Combine(basePath, "paper.png");

            if (File.Exists(scissorsPath))
                scissorsImage = Image.FromFile(scissorsPath);
            else
                MessageBox.Show("找不到剪刀圖片：" + scissorsPath);

            if (File.Exists(rockPath))
                rockImage = Image.FromFile(rockPath);
            else
                MessageBox.Show("找不到石頭圖片：" + rockPath);

            if (File.Exists(paperPath))
                paperImage = Image.FromFile(paperPath);
            else
                MessageBox.Show("找不到布圖片：" + paperPath);
        }

        // 玩家點選「剪刀」
        private void btnScissors_Click(object sender, EventArgs e)
        {
            Play(0);
        }

        // 玩家點選「石頭」
        private void btnRock_Click(object sender, EventArgs e)
        {
            Play(1);
        }

        // 玩家點選「布」
        private void btnPaper_Click(object sender, EventArgs e)
        {
            Play(2);
        }

        // 遊戲邏輯：傳入玩家選擇（0:剪刀、1:石頭、2:布），然後隨機產生電腦選擇
        private void Play(int playerChoice)
        {
            // 設定玩家圖片
            if (playerChoice == 0)
                pictureBoxPlayer.Image = scissorsImage;
            else if (playerChoice == 1)
                pictureBoxPlayer.Image = rockImage;
            else if (playerChoice == 2)
                pictureBoxPlayer.Image = paperImage;

            // 產生電腦的隨機選擇
            int computerChoice = random.Next(0, 3);
            if (computerChoice == 0)
                pictureBoxComputer.Image = scissorsImage;
            else if (computerChoice == 1)
                pictureBoxComputer.Image = rockImage;
            else if (computerChoice == 2)
                pictureBoxComputer.Image = paperImage;

            // 判斷並處理遊戲結果
            if (playerChoice == computerChoice)
            {
                drawCount++;
                MessageBox.Show("平手！");
                FormHistory.AddRecord("剪刀石頭布 - 平手");
            }
            else if ((playerChoice == 0 && computerChoice == 2) ||
                     (playerChoice == 1 && computerChoice == 0) ||
                     (playerChoice == 2 && computerChoice == 1))
            {
                winCount++;
                MessageBox.Show("恭喜您贏了！");
                FormHistory.AddRecord("剪刀石頭布 - 贏");
            }
            else
            {
                lossCount++;
                MessageBox.Show("您輸了！");
                FormHistory.AddRecord("剪刀石頭布 - 輸");
            }
            UpdateRecord();
        }

        // 更新底下顯示統計文字（贏、平手、輸）
        private void UpdateRecord()
        {
            lblRecord.Text = $"贏：{winCount} 場   平手：{drawCount} 場   輸：{lossCount} 場";
        }

        // 點選【歷史記錄】按鈕，直接建立並顯示歷史紀錄頁面 FormHistory
        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory historyForm = new FormHistory();
            historyForm.Show();
        }

        // 點選【回到大廳】按鈕，返回大廳（FormIntro）並關閉目前頁面
        private void btnBackToLobby_Click(object sender, EventArgs e)
        {
            Form lobby = Application.OpenForms["FormIntro"];
            if (lobby == null)
            {
                lobby = new FormIntro();
                lobby.Show();
            }
            else
            {
                lobby.Show();
            }
            this.Close();
        }
    }
}
