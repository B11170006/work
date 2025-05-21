namespace TrafficLightApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLight001 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLight001
            // 
            this.lblLight001.BackColor = System.Drawing.Color.Red;
            this.lblLight001.Location = new System.Drawing.Point(131, 99);
            this.lblLight001.Name = "lblLight001";
            this.lblLight001.Size = new System.Drawing.Size(100, 23);
            this.lblLight001.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLight001);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label lblLight001;
    }
}

