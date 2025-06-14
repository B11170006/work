namespace 視窗程式設計
{
    partial class FormIntro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDiceGame;
        private System.Windows.Forms.Button btnRPSGame;
        private System.Windows.Forms.Button btnGameInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            // 設定背景圖片（請確認檔案 "AG6Nnmn8BTKmnE4t7nFHc.jpeg" 放在執行檔所在資料夾）
            this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\LIN\\Downloads\\期末報告1.1\\期末報告1.0\\期末報告\\期末報告\\期末報告\\bin\\Debug\\12345678.jpg");

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDiceGame = new System.Windows.Forms.Button();
            this.btnRPSGame = new System.Windows.Forms.Button();
            this.btnGameInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lblTitle.Location = new System.Drawing.Point(150, 160);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "遊戲大廳";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiceGame
            // 
            this.btnDiceGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiceGame.FlatAppearance.BorderSize = 0;
            this.btnDiceGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiceGame.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDiceGame.Location = new System.Drawing.Point(131, 216);
            this.btnDiceGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiceGame.Name = "btnDiceGame";
            this.btnDiceGame.Size = new System.Drawing.Size(150, 48);
            this.btnDiceGame.TabIndex = 1;
            this.btnDiceGame.Text = "骰子比大小";
            this.btnDiceGame.UseVisualStyleBackColor = false;
            this.btnDiceGame.Click += new System.EventHandler(this.btnDiceGame_Click);
            // 
            // btnRPSGame
            // 
            this.btnRPSGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRPSGame.FlatAppearance.BorderSize = 0;
            this.btnRPSGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPSGame.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPSGame.Location = new System.Drawing.Point(319, 216);
            this.btnRPSGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRPSGame.Name = "btnRPSGame";
            this.btnRPSGame.Size = new System.Drawing.Size(150, 48);
            this.btnRPSGame.TabIndex = 2;
            this.btnRPSGame.Text = "剪刀石頭布";
            this.btnRPSGame.UseVisualStyleBackColor = false;
            this.btnRPSGame.Click += new System.EventHandler(this.btnRPSGame_Click);
            // 
            // btnGameInfo
            // 
            this.btnGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGameInfo.FlatAppearance.BorderSize = 0;
            this.btnGameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameInfo.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGameInfo.Location = new System.Drawing.Point(225, 280);
            this.btnGameInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGameInfo.Name = "btnGameInfo";
            this.btnGameInfo.Size = new System.Drawing.Size(150, 48);
            this.btnGameInfo.TabIndex = 3;
            this.btnGameInfo.Text = "遊戲說明";
            this.btnGameInfo.UseVisualStyleBackColor = false;
            this.btnGameInfo.Click += new System.EventHandler(this.btnGameInfo_Click);
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDiceGame);
            this.Controls.Add(this.btnRPSGame);
            this.Controls.Add(this.btnGameInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "遊戲大廳";
            this.Load += new System.EventHandler(this.FormIntro_Load);
            this.ResumeLayout(false);

        }
        #endregion
    }
}
