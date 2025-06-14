namespace 視窗程式設計
{
    partial class FormHistory
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackToLobby;
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        /// 清除所有使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 此為設計工具支援所需的方法，請勿使用程式碼編輯器修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackToLobby = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 20;
            this.listBoxHistory.Location = new System.Drawing.Point(102, 187);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(397, 124);
            this.listBoxHistory.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnClear.Location = new System.Drawing.Point(102, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除結果";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackToLobby
            // 
            this.btnBackToLobby.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnBackToLobby.Location = new System.Drawing.Point(408, 317);
            this.btnBackToLobby.Name = "btnBackToLobby";
            this.btnBackToLobby.Size = new System.Drawing.Size(91, 34);
            this.btnBackToLobby.TabIndex = 2;
            this.btnBackToLobby.Text = "回到大廳";
            this.btnBackToLobby.UseVisualStyleBackColor = true;
            this.btnBackToLobby.Click += new System.EventHandler(this.btnBackToLobby_Click);
            this.btnBackToLobby.UseVisualStyleBackColor = false;
            this.btnBackToLobby.Click += new System.EventHandler(this.btnBackToLobby_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblTitle.Location = new System.Drawing.Point(102, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "遊戲歷史紀錄 (最多10筆)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackToLobby);
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "遊戲歷史紀錄";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
