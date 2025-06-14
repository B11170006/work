namespace 視窗程式設計
{
    partial class FormGameInfo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDiceInfo;
        private System.Windows.Forms.Button btnRPSInfo;
        private System.Windows.Forms.Button btnBackToLobby;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameInfo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDiceInfo = new System.Windows.Forms.Button();
            this.btnRPSInfo = new System.Windows.Forms.Button();
            this.btnBackToLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lblTitle.Location = new System.Drawing.Point(147, 145);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "遊戲說明";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiceInfo
            // 
            this.btnDiceInfo.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDiceInfo.Location = new System.Drawing.Point(112, 215);
            this.btnDiceInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiceInfo.Name = "btnDiceInfo";
            this.btnDiceInfo.Size = new System.Drawing.Size(150, 48);
            this.btnDiceInfo.TabIndex = 1;
            this.btnDiceInfo.Text = "骰子比大小";
            this.btnDiceInfo.UseVisualStyleBackColor = false;
            this.btnDiceInfo.Click += new System.EventHandler(this.btnDiceInfo_Click);
            // 
            // btnRPSInfo
            // 
            this.btnRPSInfo.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPSInfo.Location = new System.Drawing.Point(341, 215);
            this.btnRPSInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRPSInfo.Name = "btnRPSInfo";
            this.btnRPSInfo.Size = new System.Drawing.Size(150, 48);
            this.btnRPSInfo.TabIndex = 2;
            this.btnRPSInfo.Text = "剪刀石頭布";
            this.btnRPSInfo.UseVisualStyleBackColor = false;
            this.btnRPSInfo.Click += new System.EventHandler(this.btnRPSInfo_Click);
            // 
            // btnBackToLobby
            // 
            this.btnBackToLobby.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnBackToLobby.Location = new System.Drawing.Point(225, 282);
            this.btnBackToLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToLobby.Name = "btnBackToLobby";
            this.btnBackToLobby.Size = new System.Drawing.Size(150, 48);
            this.btnBackToLobby.TabIndex = 3;
            this.btnBackToLobby.Text = "回到遊戲大廳";
            this.btnBackToLobby.UseVisualStyleBackColor = true;
            this.btnBackToLobby.Click += new System.EventHandler(this.btnBackToLobby_Click);
            // 
            // FormGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDiceInfo);
            this.Controls.Add(this.btnRPSInfo);
            this.Controls.Add(this.btnBackToLobby);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "遊戲說明";
            this.ResumeLayout(false);

        }
        #endregion
    }
}
