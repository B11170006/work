using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int computerScore = 0;
        private static readonly Random random = new Random();
        private readonly Random rand = random;

        public Form1(Random rand)
        {
            this.rand = rand;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            int playerRoll = rand.Next(1, 7);
            int computerRoll = rand.Next(1, 7);

            try
            {
                picPlayer.Image = Image.FromFile($"Images/dice{playerRoll}.png");
                picComputer.Image = Image.FromFile($"Images/dice{computerRoll}.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片載入失敗：" + ex.Message);
            }

            if (playerRoll > computerRoll)
            {
                playerScore++;
                lblResult.Text = "你贏了！";
            }
            else if (playerRoll < computerRoll)
            {
                computerScore++;
                lblResult.Text = "你輸了！";
            }
            else
            {
                lblResult.Text = "平手！";
            }

            UpdateScores();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetScores();
            picPlayer.Image = null;
            picComputer.Image = null;
            lblResult.Text = "分數已重置，請重新開始！";
        }

        private void UpdateScores()
        {
            lblPlayerScore.Text = $"玩家分數：{playerScore}";
            lblComputerScore.Text = $"電腦分數：{computerScore}";
        }

        private void ResetScores()
        {
            playerScore = 0;
            computerScore = 0;
            UpdateScores();
        }
    }
}
