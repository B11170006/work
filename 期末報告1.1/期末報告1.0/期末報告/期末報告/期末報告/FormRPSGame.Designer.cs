namespace 視窗程式設計
{
    partial class FormRPSGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxComputer;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBackToLobby;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRPSGame));
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxComputer = new System.Windows.Forms.PictureBox();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBackToLobby = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(81, 28);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(150, 160);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxComputer
            // 
            this.pictureBoxComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxComputer.Location = new System.Drawing.Point(381, 28);
            this.pictureBoxComputer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxComputer.Name = "pictureBoxComputer";
            this.pictureBoxComputer.Size = new System.Drawing.Size(150, 160);
            this.pictureBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxComputer.TabIndex = 1;
            this.pictureBoxComputer.TabStop = false;
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnScissors.Location = new System.Drawing.Point(105, 212);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(2);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 40);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "剪刀";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRock.Location = new System.Drawing.Point(262, 212);
            this.btnRock.Margin = new System.Windows.Forms.Padding(2);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 40);
            this.btnRock.TabIndex = 3;
            this.btnRock.Text = "石頭";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnPaper.Location = new System.Drawing.Point(417, 212);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 40);
            this.btnPaper.TabIndex = 4;
            this.btnPaper.Text = "布";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblRecord.Location = new System.Drawing.Point(132, 278);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(375, 24);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "贏：0 場   平手：0 場   輸：0 場";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnHistory.Location = new System.Drawing.Point(105, 322);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(112, 40);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "歷史記錄";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBackToLobby
            // 
            this.btnBackToLobby.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnBackToLobby.Location = new System.Drawing.Point(395, 322);
            this.btnBackToLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToLobby.Name = "btnBackToLobby";
            this.btnBackToLobby.Size = new System.Drawing.Size(112, 40);
            this.btnBackToLobby.TabIndex = 7;
            this.btnBackToLobby.Text = "回到大廳";
            this.btnBackToLobby.UseVisualStyleBackColor = true;
            this.btnBackToLobby.Click += new System.EventHandler(this.btnBackToLobby_Click);
            // 
            // FormRPSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxComputer);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBackToLobby);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRPSGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "剪刀石頭布";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
