namespace WinFormsPolymorphism4
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
            this.btnCal = new System.Windows.Forms.Button();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(247, 224);
            this.btnCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(88, 33);
            this.btnCal.TabIndex = 32;
            this.btnCal.Text = "計算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiv.Location = new System.Drawing.Point(273, 174);
            this.rdbDiv.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(50, 24);
            this.rdbDiv.TabIndex = 31;
            this.rdbDiv.Text = "除";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.CheckedChanged += new System.EventHandler(this.rdbDiv_CheckedChanged);
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMul.Location = new System.Drawing.Point(273, 130);
            this.rdbMul.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(50, 24);
            this.rdbMul.TabIndex = 30;
            this.rdbMul.Text = "乘";
            this.rdbMul.UseVisualStyleBackColor = true;
            this.rdbMul.CheckedChanged += new System.EventHandler(this.rdbMul_CheckedChanged);
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSub.Location = new System.Drawing.Point(273, 83);
            this.rdbSub.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(50, 24);
            this.rdbSub.TabIndex = 29;
            this.rdbSub.Text = "減";
            this.rdbSub.UseVisualStyleBackColor = true;
            this.rdbSub.CheckedChanged += new System.EventHandler(this.rdbSub_CheckedChanged);
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Checked = true;
            this.rdbAdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdd.Location = new System.Drawing.Point(273, 42);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(50, 24);
            this.rdbAdd.TabIndex = 28;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "加";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(96, 167);
            this.txtAns.Margin = new System.Windows.Forms.Padding(4);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(138, 31);
            this.txtAns.TabIndex = 27;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(96, 106);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(132, 31);
            this.txtY.TabIndex = 26;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(96, 43);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(132, 31);
            this.txtX.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "結果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "X :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 298);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.rdbDiv);
            this.Controls.Add(this.rdbMul);
            this.Controls.Add(this.rdbSub);
            this.Controls.Add(this.rdbAdd);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "多型-範例一";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

