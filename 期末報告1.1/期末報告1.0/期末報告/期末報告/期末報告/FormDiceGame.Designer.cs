using System.Drawing;
using System.Windows.Forms;

namespace 視窗程式設計
{
    partial class FormDiceGame
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnGuessBig;
        private Button btnRoll;
        private Button btnGuessSmall;
        private Button btnBackToLobby;
        private Button btnHistory;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGuessBig = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnGuessSmall = new System.Windows.Forms.Button();
            this.btnBackToLobby = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(260, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(413, 132);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnGuessBig
            // 
            this.btnGuessBig.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGuessBig.Location = new System.Drawing.Point(116, 220);
            this.btnGuessBig.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuessBig.Name = "btnGuessBig";
            this.btnGuessBig.Size = new System.Drawing.Size(60, 30);
            this.btnGuessBig.TabIndex = 3;
            this.btnGuessBig.Text = "大";
            this.btnGuessBig.UseVisualStyleBackColor = true;
            this.btnGuessBig.Click += new System.EventHandler(this.btnGuessBig_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRoll.Location = new System.Drawing.Point(260, 220);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(60, 30);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "搖骰";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnGuessSmall
            // 
            this.btnGuessSmall.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGuessSmall.Location = new System.Drawing.Point(413, 220);
            this.btnGuessSmall.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuessSmall.Name = "btnGuessSmall";
            this.btnGuessSmall.Size = new System.Drawing.Size(60, 30);
            this.btnGuessSmall.TabIndex = 5;
            this.btnGuessSmall.Text = "小";
            this.btnGuessSmall.UseVisualStyleBackColor = true;
            this.btnGuessSmall.Click += new System.EventHandler(this.btnGuessSmall_Click);
            // 
            // btnBackToLobby
            // 
            this.btnBackToLobby.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnBackToLobby.Location = new System.Drawing.Point(104, 257);
            this.btnBackToLobby.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToLobby.Name = "btnBackToLobby";
            this.btnBackToLobby.Size = new System.Drawing.Size(85, 40);
            this.btnBackToLobby.TabIndex = 6;
            this.btnBackToLobby.Text = "回到大廳";
            this.btnBackToLobby.UseVisualStyleBackColor = true;
            this.btnBackToLobby.Click += new System.EventHandler(this.btnBackToLobby_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnHistory.Location = new System.Drawing.Point(413, 257);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(90, 40);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "歷史紀錄";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblStatus.Location = new System.Drawing.Point(112, 310);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(391, 37);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "請選擇【大】或【小】，然後點擊 [搖骰]！";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuessBig);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnGuessSmall);
            this.Controls.Add(this.btnBackToLobby);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDiceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "骰子比大小";
            this.Load += new System.EventHandler(this.FormDiceGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
