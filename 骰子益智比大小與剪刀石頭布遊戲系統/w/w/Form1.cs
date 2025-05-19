using System;
using System.Windows.Forms;

namespace w
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            string userChoice = "剪刀";
            PlayGame(userChoice);
        }
        private void PlayGame(string userChoice)
        {
            string[] choices = { "剪刀", "石頭", "布" };
            Random rnd = new Random();
            string computerChoice = choices[rnd.Next(choices.Length)];

            lblResult.Text = $"電腦選擇：{computerChoice}\n";

            if (userChoice == computerChoice)
                lblResult.Text += "平手！";
            else if ((userChoice == "剪刀" && computerChoice == "布") ||
                     (userChoice == "布" && computerChoice == "石頭") ||
                     (userChoice == "石頭" && computerChoice == "剪刀"))
                lblResult.Text += "你贏了！";
            else
                lblResult.Text += "你輸了！";
        }

        private void btnRock_Click_1(object sender, EventArgs e)
        {
            string userChoice = "石頭";
            PlayGame(userChoice);
        }

        private void btnPaper_Click_1(object sender, EventArgs e)
        {
            string userChoice = "布";
            PlayGame(userChoice);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "請選擇剪刀、石頭或布開始遊戲！";
            picComputerChoice.Image = null;
            picComputerChoice.Image = null;
        }
    }
}
