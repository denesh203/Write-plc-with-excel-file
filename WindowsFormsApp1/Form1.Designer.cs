namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Lamp = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Cmtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Writebtn = new System.Windows.Forms.Button();
            this.Disbtn = new System.Windows.Forms.Button();
            this.Connbtn = new System.Windows.Forms.Button();
            this.label980 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DDbtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label330 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dbtn = new System.Windows.Forms.Button();
            this.Openbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Lamp);
            this.panel1.Controls.Add(this.label65);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 70);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1161, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "PLC OFF";
            // 
            // Lamp
            // 
            this.Lamp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lamp.Location = new System.Drawing.Point(1246, 46);
            this.Lamp.Multiline = true;
            this.Lamp.Name = "Lamp";
            this.Lamp.ReadOnly = true;
            this.Lamp.Size = new System.Drawing.Size(35, 19);
            this.Lamp.TabIndex = 3;
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label65.Location = new System.Drawing.Point(1173, 15);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(55, 17);
            this.label65.TabIndex = 1;
            this.label65.Text = "label65";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = " ExcelファイルをPLCに書き込み";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(920, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(917, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 579);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Resetbtn);
            this.panel4.Controls.Add(this.Cmtbox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(8, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 443);
            this.panel4.TabIndex = 1;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Resetbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Resetbtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Resetbtn.Location = new System.Drawing.Point(12, 407);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(343, 30);
            this.Resetbtn.TabIndex = 17;
            this.Resetbtn.Text = "リセット";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Cmtbox
            // 
            this.Cmtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmtbox.BackColor = System.Drawing.Color.Gray;
            this.Cmtbox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmtbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Cmtbox.Location = new System.Drawing.Point(12, 325);
            this.Cmtbox.Multiline = true;
            this.Cmtbox.Name = "Cmtbox";
            this.Cmtbox.ReadOnly = true;
            this.Cmtbox.Size = new System.Drawing.Size(343, 77);
            this.Cmtbox.TabIndex = 16;
            this.Cmtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "ExcelデータからPLCへの書き込み";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Writebtn);
            this.panel7.Controls.Add(this.Disbtn);
            this.panel7.Controls.Add(this.Connbtn);
            this.panel7.Controls.Add(this.label980);
            this.panel7.Location = new System.Drawing.Point(12, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 165);
            this.panel7.TabIndex = 1;
            // 
            // Writebtn
            // 
            this.Writebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Writebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Writebtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Writebtn.Location = new System.Drawing.Point(19, 108);
            this.Writebtn.Name = "Writebtn";
            this.Writebtn.Size = new System.Drawing.Size(296, 51);
            this.Writebtn.TabIndex = 21;
            this.Writebtn.Text = "書き込みボタン";
            this.Writebtn.UseVisualStyleBackColor = false;
            this.Writebtn.Click += new System.EventHandler(this.Writebtn_Click);
            // 
            // Disbtn
            // 
            this.Disbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Disbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Disbtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Disbtn.Location = new System.Drawing.Point(181, 49);
            this.Disbtn.Name = "Disbtn";
            this.Disbtn.Size = new System.Drawing.Size(149, 54);
            this.Disbtn.TabIndex = 20;
            this.Disbtn.Text = "切断";
            this.Disbtn.UseVisualStyleBackColor = false;
            this.Disbtn.Click += new System.EventHandler(this.Disbtn_Click);
            // 
            // Connbtn
            // 
            this.Connbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Connbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Connbtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Connbtn.Location = new System.Drawing.Point(19, 49);
            this.Connbtn.Name = "Connbtn";
            this.Connbtn.Size = new System.Drawing.Size(149, 54);
            this.Connbtn.TabIndex = 19;
            this.Connbtn.Text = "接続";
            this.Connbtn.UseVisualStyleBackColor = false;
            this.Connbtn.Click += new System.EventHandler(this.Connbtn_Click);
            // 
            // label980
            // 
            this.label980.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label980.AutoSize = true;
            this.label980.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label980.Location = new System.Drawing.Point(43, 0);
            this.label980.Name = "label980";
            this.label980.Size = new System.Drawing.Size(250, 26);
            this.label980.TabIndex = 18;
            this.label980.Text = " PLCを接続して書き込み";
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.DDbtn);
            this.panel5.Controls.Add(this.Header);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label330);
            this.panel5.Location = new System.Drawing.Point(12, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 120);
            this.panel5.TabIndex = 0;
            // 
            // DDbtn
            // 
            this.DDbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DDbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DDbtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DDbtn.Location = new System.Drawing.Point(74, 77);
            this.DDbtn.Name = "DDbtn";
            this.DDbtn.Size = new System.Drawing.Size(219, 39);
            this.DDbtn.TabIndex = 20;
            this.DDbtn.Text = "Delete";
            this.DDbtn.UseVisualStyleBackColor = false;
            this.DDbtn.Click += new System.EventHandler(this.DDbtn_Click);
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(137, 39);
            this.Header.Multiline = true;
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(167, 35);
            this.Header.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "列ヘッダー";
            // 
            // label330
            // 
            this.label330.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label330.AutoSize = true;
            this.label330.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label330.Location = new System.Drawing.Point(27, 10);
            this.label330.Name = "label330";
            this.label330.Size = new System.Drawing.Size(274, 26);
            this.label330.TabIndex = 16;
            this.label330.Text = "Excelを書き込み可能にする";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Dbtn);
            this.panel3.Controls.Add(this.Openbtn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(8, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 120);
            this.panel3.TabIndex = 0;
            // 
            // Dbtn
            // 
            this.Dbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dbtn.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dbtn.Location = new System.Drawing.Point(216, 60);
            this.Dbtn.Name = "Dbtn";
            this.Dbtn.Size = new System.Drawing.Size(129, 45);
            this.Dbtn.TabIndex = 8;
            this.Dbtn.Text = "データを削除";
            this.Dbtn.UseVisualStyleBackColor = false;
            this.Dbtn.Click += new System.EventHandler(this.Dbtn_Click);
            // 
            // Openbtn
            // 
            this.Openbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Openbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Openbtn.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Openbtn.Location = new System.Drawing.Point(32, 60);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(160, 45);
            this.Openbtn.TabIndex = 7;
            this.Openbtn.Text = "ファイルを開く";
            this.Openbtn.UseVisualStyleBackColor = false;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Excelファイルを開く";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ExcelからPLC書き込み";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox Lamp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Dbtn;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.TextBox Cmtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Writebtn;
        private System.Windows.Forms.Button Disbtn;
        private System.Windows.Forms.Button Connbtn;
        private System.Windows.Forms.Label label980;
        private System.Windows.Forms.Button DDbtn;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label330;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

