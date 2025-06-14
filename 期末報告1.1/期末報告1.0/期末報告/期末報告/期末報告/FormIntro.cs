using System;
using System.Windows.Forms;

namespace 視窗程式設計
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        // 點選【骰子比大小】按鈕，直接跳轉到骰子遊戲頁面
        private void btnDiceGame_Click(object sender, EventArgs e)
        {
            FormDiceGame frmDice = new FormDiceGame();
            frmDice.Show();
            this.Hide();
        }

        // 點選【剪刀石頭布】按鈕，直接跳轉到剪刀石頭布遊戲頁面
        private void btnRPSGame_Click(object sender, EventArgs e)
        {
            FormRPSGame frmRPS = new FormRPSGame();
            frmRPS.Show();
            this.Hide();
        }

        // 點選【遊戲說明】按鈕，跳轉到遊戲說明頁面
        private void btnGameInfo_Click(object sender, EventArgs e)
        {
            FormGameInfo infoForm = new FormGameInfo();
            infoForm.Show();
            this.Hide();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {

        }
    }
}
