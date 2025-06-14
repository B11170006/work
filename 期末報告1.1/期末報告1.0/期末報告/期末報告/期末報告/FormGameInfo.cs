using System;
using System.Windows.Forms;

namespace 視窗程式設計
{
    public partial class FormGameInfo : Form
    {
        public FormGameInfo()
        {
            InitializeComponent();
        }

        // 點選「骰子比大小」按鈕，顯示約100字說明
        private void btnDiceInfo_Click(object sender, EventArgs e)
        {
            string info = "【骰子比大小】遊戲中，玩家先選擇『大』或『小』，再按下『搖骰』擲出三顆骰子。若三骰總和大於9判定為大，否則為小。猜中即獲勝，遊戲充滿簡單的運氣與趣味！";
            MessageBox.Show(info, "骰子比大小 說明");
        }

        // 點選「剪刀石頭布」按鈕，顯示約100字說明
        private void btnRPSInfo_Click(object sender, EventArgs e)
        {
            string info = "【剪刀石頭布】遊戲是經典對戰，玩家選擇剪刀、石頭或布，各自遵循剪刀勝布、石頭勝剪刀、布勝石頭的規則。遊戲考驗快思反應和心理戰術，讓對決充滿樂趣！";
            MessageBox.Show(info, "剪刀石頭布 說明");
        }

        // 點選「回到遊戲大廳」按鈕，關閉所有畫面只留下遊戲大廳
        private void btnBackToLobby_Click(object sender, EventArgs e)
        {
            // 顯示已存在的 FormIntro，如若不存在則建立新的
            Form intro = Application.OpenForms["FormIntro"];
            if (intro != null)
                intro.Show();
            else
            {
                intro = new FormIntro();
                intro.Show();
            }
            this.Close();
        }
    }
}
