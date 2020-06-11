namespace WindowsFormsApp1
{
    partial class LTH
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtmlth = new System.Windows.Forms.TextBox();
            this.txtndth = new System.Windows.Forms.TextBox();
            this.txtnth = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.DTV_LTH = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTV_LTH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(752, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 53);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ LỊCH THỰC HÀNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lịch thực hành";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày thực hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung thực hành";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtmlth
            // 
            this.txtmlth.Location = new System.Drawing.Point(141, 53);
            this.txtmlth.Name = "txtmlth";
            this.txtmlth.Size = new System.Drawing.Size(100, 20);
            this.txtmlth.TabIndex = 2;
            // 
            // txtndth
            // 
            this.txtndth.Location = new System.Drawing.Point(141, 119);
            this.txtndth.Name = "txtndth";
            this.txtndth.Size = new System.Drawing.Size(100, 20);
            this.txtndth.TabIndex = 3;
            // 
            // txtnth
            // 
            this.txtnth.Location = new System.Drawing.Point(141, 88);
            this.txtnth.Name = "txtnth";
            this.txtnth.Size = new System.Drawing.Size(100, 20);
            this.txtnth.TabIndex = 3;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(343, 81);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(120, 20);
            this.txttk.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(724, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 53);
            this.button5.TabIndex = 0;
            this.button5.Text = "Nghiệp vụ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập để tìm kiếm";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(556, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 53);
            this.button6.TabIndex = 0;
            this.button6.Text = "Chi tiết lịch thực hành";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // DTV_LTH
            // 
            this.DTV_LTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_LTH.Location = new System.Drawing.Point(22, 216);
            this.DTV_LTH.Name = "DTV_LTH";
            this.DTV_LTH.Size = new System.Drawing.Size(451, 131);
            this.DTV_LTH.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(650, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 46);
            this.button7.TabIndex = 5;
            this.button7.Text = "Hiển thị";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // LTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.DTV_LTH);
            this.Controls.Add(this.txtnth);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtndth);
            this.Controls.Add(this.txtmlth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "LTH";
            this.Text = "Lịch thực hành";
            this.Load += new System.EventHandler(this.LTH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_LTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmlth;
        private System.Windows.Forms.TextBox txtndth;
        private System.Windows.Forms.TextBox txtnth;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView DTV_LTH;
        private System.Windows.Forms.Button button7;
    }
}

