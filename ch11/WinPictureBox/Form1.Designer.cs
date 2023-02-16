namespace WinPictureBox
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.picShow = new System.Windows.Forms.PictureBox();
            this.cboPhotoName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(47, 91);
            this.picShow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(269, 190);
            this.picShow.TabIndex = 11;
            this.picShow.TabStop = false;
            // 
            // cboPhotoName
            // 
            this.cboPhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhotoName.FormattingEnabled = true;
            this.cboPhotoName.Location = new System.Drawing.Point(143, 41);
            this.cboPhotoName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboPhotoName.Name = "cboPhotoName";
            this.cboPhotoName.Size = new System.Drawing.Size(173, 30);
            this.cboPhotoName.TabIndex = 10;
            this.cboPhotoName.SelectedIndexChanged += new System.EventHandler(this.cboPhotoName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "圖片名稱";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.cboPhotoName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.ComboBox cboPhotoName;
        private System.Windows.Forms.Label label1;
    }
}

