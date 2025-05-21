using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightApp
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            // 如果你沒有特殊初始化，可以留空
        }

        public Form1()
        {
            InitializeComponent();

            // 設定預設紅燈
            lblLight001.BackColor = Color.Red;
            
            lblLight001.TextAlign = ContentAlignment.MiddleCenter;

            // 設定大小和樣式
            lblLight001.Font = new Font("Microsoft JhengHei", 16, FontStyle.Bold);
            lblLight001.AutoSize = false;
            lblLight001.Width = 100;
            lblLight001.Height = 100;

            // 加入滑鼠事件
            lblLight001.MouseDown += LblLight_MouseDown;
        }

        private void LblLight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblLight001.BackColor = Color.Yellow;
              
            }
            else if (e.Button == MouseButtons.Right)
            {
                lblLight001.BackColor = Color.Green;
                
            }
        }
    }
}