namespace Linq_Method1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnPriceAsc = new System.Windows.Forms.Button();
            this.btnPriceDesc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "書名關鍵字查詢";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(144, 33);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(148, 25);
            this.txtKeyword.TabIndex = 2;
            // 
            // btnBookList
            // 
            this.btnBookList.Location = new System.Drawing.Point(491, 99);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(113, 25);
            this.btnBookList.TabIndex = 0;
            this.btnBookList.Text = "書籍列表";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnPriceAsc
            // 
            this.btnPriceAsc.Location = new System.Drawing.Point(491, 162);
            this.btnPriceAsc.Name = "btnPriceAsc";
            this.btnPriceAsc.Size = new System.Drawing.Size(113, 25);
            this.btnPriceAsc.TabIndex = 0;
            this.btnPriceAsc.Text = "單價遞增排序";
            this.btnPriceAsc.UseVisualStyleBackColor = true;
            this.btnPriceAsc.Click += new System.EventHandler(this.btnPriceAsc_Click);
            // 
            // btnPriceDesc
            // 
            this.btnPriceDesc.Location = new System.Drawing.Point(491, 225);
            this.btnPriceDesc.Name = "btnPriceDesc";
            this.btnPriceDesc.Size = new System.Drawing.Size(113, 25);
            this.btnPriceDesc.TabIndex = 0;
            this.btnPriceDesc.Text = "單價遞減排序";
            this.btnPriceDesc.UseVisualStyleBackColor = true;
            this.btnPriceDesc.Click += new System.EventHandler(this.btnPriceDesc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 167);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPriceDesc);
            this.Controls.Add(this.btnPriceAsc);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnPriceAsc;
        private System.Windows.Forms.Button btnPriceDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

