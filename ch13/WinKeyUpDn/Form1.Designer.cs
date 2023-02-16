namespace WinKeyUpDn
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.picTankD = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.picTankR = new System.Windows.Forms.PictureBox();
            this.picTankL = new System.Windows.Forms.PictureBox();
            this.picTankU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(41, 310);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(46, 17);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "label3";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(41, 280);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(46, 17);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "label2";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(41, 245);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(46, 17);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "label1";
            // 
            // picTankD
            // 
            this.picTankD.Image = global::WinKeyUpDn.Properties.Resources.tankD;
            this.picTankD.Location = new System.Drawing.Point(35, 136);
            this.picTankD.Margin = new System.Windows.Forms.Padding(4);
            this.picTankD.Name = "picTankD";
            this.picTankD.Size = new System.Drawing.Size(65, 71);
            this.picTankD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankD.TabIndex = 4;
            this.picTankD.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.Location = new System.Drawing.Point(141, 93);
            this.picTank.Margin = new System.Windows.Forms.Padding(4);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(74, 64);
            this.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTank.TabIndex = 5;
            this.picTank.TabStop = false;
            // 
            // picTankR
            // 
            this.picTankR.Image = global::WinKeyUpDn.Properties.Resources.tankR;
            this.picTankR.Location = new System.Drawing.Point(259, 140);
            this.picTankR.Margin = new System.Windows.Forms.Padding(4);
            this.picTankR.Name = "picTankR";
            this.picTankR.Size = new System.Drawing.Size(71, 67);
            this.picTankR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankR.TabIndex = 6;
            this.picTankR.TabStop = false;
            // 
            // picTankL
            // 
            this.picTankL.Image = global::WinKeyUpDn.Properties.Resources.tankL;
            this.picTankL.Location = new System.Drawing.Point(259, 34);
            this.picTankL.Margin = new System.Windows.Forms.Padding(4);
            this.picTankL.Name = "picTankL";
            this.picTankL.Size = new System.Drawing.Size(76, 64);
            this.picTankL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankL.TabIndex = 7;
            this.picTankL.TabStop = false;
            // 
            // picTankU
            // 
            this.picTankU.Image = global::WinKeyUpDn.Properties.Resources.tankU;
            this.picTankU.Location = new System.Drawing.Point(35, 25);
            this.picTankU.Margin = new System.Windows.Forms.Padding(4);
            this.picTankU.Name = "picTankU";
            this.picTankU.Size = new System.Drawing.Size(66, 73);
            this.picTankU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankU.TabIndex = 8;
            this.picTankU.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 356);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.picTankD);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picTankR);
            this.Controls.Add(this.picTankL);
            this.Controls.Add(this.picTankU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox picTankD;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.PictureBox picTankR;
        private System.Windows.Forms.PictureBox picTankL;
        private System.Windows.Forms.PictureBox picTankU;
    }
}

