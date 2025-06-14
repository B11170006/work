using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 視窗程式設計
{
    public partial class FormHistory : Form
    {
        // 靜態記錄列表，儲存兩款遊戲的遊玩結果
        public static List<string> Records = new List<string>();

        /// <summary>
        /// 新增一筆記錄到歷史紀錄中
        /// </summary>
        /// <param name="record">記錄內容（例如 "骰子比大小 - 贏"）</param>
        public static void AddRecord(string record)
        {
            Records.Add(record);
            // 若需要限制筆數，例如只保留最新 10 筆，可取消下面註解
            // if (Records.Count > 10)
            //     Records.RemoveAt(0);
        }

        public FormHistory()
        {
            InitializeComponent();
            LoadHistory();
        }

        /// <summary>
        /// 將儲存的記錄載入 ListBox 顯示
        /// </summary>
        public void LoadHistory()
        {
            listBoxHistory.Items.Clear();
            foreach (string rec in Records)
            {
                listBoxHistory.Items.Add(rec);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Records.Clear();
            LoadHistory();
        }

        /// <summary>
        /// 點選「回到大廳」按鈕後關閉除 FormIntro 外的所有視窗，並顯示遊戲大廳
        /// </summary>
        private void btnBackToLobby_Click(object sender, EventArgs e)
        {
            // 從後往前遍歷所有已開啟的窗體
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];
                if (!(frm is FormIntro))
                    frm.Close();
            }
            // 若大廳視窗不存在則建立
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
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
