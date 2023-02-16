namespace WinToolStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCls = new System.Windows.Forms.ToolStripButton();
            this.tsbBullet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Yellow;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbCls,
            this.tsbBullet,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cboSize,
            this.toolStripSeparator1,
            this.tsbFontColor});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::WinToolStrip.Properties.Resources.OPEN;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(63, 24);
            this.tsbOpen.Text = "開檔";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::WinToolStrip.Properties.Resources.SAVE;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(63, 24);
            this.tsbSave.Text = "存檔";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCls
            // 
            this.tsbCls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCls.Image = ((System.Drawing.Image)(resources.GetObject("tsbCls.Image")));
            this.tsbCls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCls.Name = "tsbCls";
            this.tsbCls.Size = new System.Drawing.Size(43, 24);
            this.tsbCls.Text = "清除";
            this.tsbCls.Click += new System.EventHandler(this.tsbCls_Click);
            // 
            // tsbBullet
            // 
            this.tsbBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBullet.Image = ((System.Drawing.Image)(resources.GetObject("tsbBullet.Image")));
            this.tsbBullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBullet.Name = "tsbBullet";
            this.tsbBullet.Size = new System.Drawing.Size(73, 24);
            this.tsbBullet.Text = "項目符號";
            this.tsbBullet.Click += new System.EventHandler(this.tsbBullet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 24);
            this.toolStripLabel1.Text = "字型大小";
            // 
            // cboSize
            // 
            this.cboSize.Items.AddRange(new object[] {
            "9",
            "10",
            "12",
            "14",
            "16"});
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(75, 27);
            this.cboSize.Text = "9";
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            this.cboSize.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbFontColor
            // 
            this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑ToolStripMenuItem,
            this.紅ToolStripMenuItem,
            this.綠ToolStripMenuItem,
            this.藍ToolStripMenuItem});
            this.tsbFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontColor.Image")));
            this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontColor.Name = "tsbFontColor";
            this.tsbFontColor.Size = new System.Drawing.Size(88, 24);
            this.tsbFontColor.Text = "字型色彩";
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.黑ToolStripMenuItem.Text = "黑";
            this.黑ToolStripMenuItem.Click += new System.EventHandler(this.黑ToolStripMenuItem_Click);
            // 
            // 紅ToolStripMenuItem
            // 
            this.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            this.紅ToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.紅ToolStripMenuItem.Text = "紅";
            this.紅ToolStripMenuItem.Click += new System.EventHandler(this.紅ToolStripMenuItem_Click);
            // 
            // 綠ToolStripMenuItem
            // 
            this.綠ToolStripMenuItem.Name = "綠ToolStripMenuItem";
            this.綠ToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.綠ToolStripMenuItem.Text = "綠";
            this.綠ToolStripMenuItem.Click += new System.EventHandler(this.綠ToolStripMenuItem_Click);
            // 
            // 藍ToolStripMenuItem
            // 
            this.藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            this.藍ToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.藍ToolStripMenuItem.Text = "藍";
            this.藍ToolStripMenuItem.Click += new System.EventHandler(this.藍ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(32, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 137);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(608, 302);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(608, 329);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 329);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCls;
        private System.Windows.Forms.ToolStripButton tsbBullet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsbFontColor;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

