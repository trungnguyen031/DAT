namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmlth = new System.Windows.Forms.TextBox();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.txthtnv = new System.Windows.Forms.TextBox();
            this.txtmgv = new System.Windows.Forms.TextBox();
            this.txtnth = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtgbd = new System.Windows.Forms.TextBox();
            this.txtgkt = new System.Windows.Forms.TextBox();
            this.txthtgv = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.DTV_TH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTV_TH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(557, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Hiển thị";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập để tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lịch thực hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã giáo viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày thực hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giờ bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giờ kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Họ tên giáo viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Họ tên nhân viên";
            // 
            // txtmlth
            // 
            this.txtmlth.Location = new System.Drawing.Point(108, 42);
            this.txtmlth.Name = "txtmlth";
            this.txtmlth.Size = new System.Drawing.Size(100, 20);
            this.txtmlth.TabIndex = 10;
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(108, 84);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(100, 20);
            this.txtmnv.TabIndex = 11;
            // 
            // txthtnv
            // 
            this.txthtnv.Location = new System.Drawing.Point(108, 132);
            this.txthtnv.Name = "txthtnv";
            this.txthtnv.Size = new System.Drawing.Size(100, 20);
            this.txthtnv.TabIndex = 12;
            // 
            // txtmgv
            // 
            this.txtmgv.Location = new System.Drawing.Point(108, 174);
            this.txtmgv.Name = "txtmgv";
            this.txtmgv.Size = new System.Drawing.Size(100, 20);
            this.txtmgv.TabIndex = 13;
            // 
            // txtnth
            // 
            this.txtnth.Location = new System.Drawing.Point(321, 63);
            this.txtnth.Name = "txtnth";
            this.txtnth.Size = new System.Drawing.Size(100, 20);
            this.txtnth.TabIndex = 14;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(321, 108);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 15;
            // 
            // txtgbd
            // 
            this.txtgbd.Location = new System.Drawing.Point(321, 150);
            this.txtgbd.Name = "txtgbd";
            this.txtgbd.Size = new System.Drawing.Size(100, 20);
            this.txtgbd.TabIndex = 16;
            // 
            // txtgkt
            // 
            this.txtgkt.Location = new System.Drawing.Point(321, 196);
            this.txtgkt.Name = "txtgkt";
            this.txtgkt.Size = new System.Drawing.Size(100, 20);
            this.txtgkt.TabIndex = 17;
            // 
            // txthtgv
            // 
            this.txthtgv.Location = new System.Drawing.Point(108, 216);
            this.txthtgv.Name = "txthtgv";
            this.txthtgv.Size = new System.Drawing.Size(100, 20);
            this.txthtgv.TabIndex = 18;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(498, 132);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(191, 20);
            this.txttk.TabIndex = 20;
            // 
            // DTV_TH
            // 
            this.DTV_TH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_TH.Location = new System.Drawing.Point(19, 278);
            this.DTV_TH.Name = "DTV_TH";
            this.DTV_TH.Size = new System.Drawing.Size(755, 181);
            this.DTV_TH.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.DTV_TH);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txthtgv);
            this.Controls.Add(this.txtgkt);
            this.Controls.Add(this.txtgbd);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtnth);
            this.Controls.Add(this.txtmgv);
            this.Controls.Add(this.txthtnv);
            this.Controls.Add(this.txtmnv);
            this.Controls.Add(this.txtmlth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Chi tiết lịch thực hành";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_TH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmlth;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.TextBox txthtnv;
        private System.Windows.Forms.TextBox txtmgv;
        private System.Windows.Forms.TextBox txtnth;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtgbd;
        private System.Windows.Forms.TextBox txtgkt;
        private System.Windows.Forms.TextBox txthtgv;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.DataGridView DTV_TH;
    }
}