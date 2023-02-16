namespace WinStatusStrip
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.最末張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(431, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 21);
            this.toolStripStatusLabel1.Text = "下載中 ....";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最末張ToolStripMenuItem,
            this.下一張ToolStripMenuItem,
            this.上一張ToolStripMenuItem,
            this.第一張ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::WinStatusStrip.Properties.Resources.OPEN;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 最末張ToolStripMenuItem
            // 
            this.最末張ToolStripMenuItem.Name = "最末張ToolStripMenuItem";
            this.最末張ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.最末張ToolStripMenuItem.Text = "最末張";
            this.最末張ToolStripMenuItem.Click += new System.EventHandler(this.最末張ToolStripMenuItem_Click);
            // 
            // 下一張ToolStripMenuItem
            // 
            this.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem";
            this.下一張ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.下一張ToolStripMenuItem.Text = "下一張";
            this.下一張ToolStripMenuItem.Click += new System.EventHandler(this.下一張ToolStripMenuItem_Click);
            // 
            // 上一張ToolStripMenuItem
            // 
            this.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem";
            this.上一張ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.上一張ToolStripMenuItem.Text = "上一張";
            this.上一張ToolStripMenuItem.Click += new System.EventHandler(this.上一張ToolStripMenuItem_Click);
            // 
            // 第一張ToolStripMenuItem
            // 
            this.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem";
            this.第一張ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.第一張ToolStripMenuItem.Text = "第一張";
            this.第一張ToolStripMenuItem.Click += new System.EventHandler(this.第一張ToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 329);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 最末張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一張ToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

