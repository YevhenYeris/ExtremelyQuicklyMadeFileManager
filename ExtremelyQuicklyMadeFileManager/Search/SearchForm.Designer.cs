namespace ExtremelyQuicklyMadeFileManager
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Controls.Add(this.pathBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.15385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(3, 240);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(78, 29);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(3, 3);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(125, 27);
            this.pathBox.TabIndex = 1;
            this.pathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(3, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 27);
            this.nameBox.TabIndex = 2;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(3, 105);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(125, 27);
            this.sizeBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(3, 142);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(125, 27);
            this.dateBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "FileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Extension";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}