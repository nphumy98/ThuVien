
using ThuVien.Helpers;

namespace ThuVien.Pages
{
    partial class NhanVienMenu
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
            this.ThongTinCaNhan = new System.Windows.Forms.Button();
            this.VeTrangDangNhap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThongTinCaNhan
            // 
            this.ThongTinCaNhan.Location = new System.Drawing.Point(291, 318);
            this.ThongTinCaNhan.Name = "ThongTinCaNhan";
            this.ThongTinCaNhan.Size = new System.Drawing.Size(118, 50);
            this.ThongTinCaNhan.TabIndex = 0;
            this.ThongTinCaNhan.Text = "Thong Tin Ca Nhan";
            this.ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.ThongTinCaNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // VeTrangDangNhap
            // 
            this.VeTrangDangNhap.Location = new System.Drawing.Point(291, 383);
            this.VeTrangDangNhap.Name = "VeTrangDangNhap";
            this.VeTrangDangNhap.Size = new System.Drawing.Size(118, 55);
            this.VeTrangDangNhap.TabIndex = 1;
            this.VeTrangDangNhap.Text = "Ve Trang Dang Nhap";
            this.VeTrangDangNhap.UseVisualStyleBackColor = true;
            this.VeTrangDangNhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quan Ly Nhan Vien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quan Ly Doc Gia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Quan Ly Sach";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(291, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "Duyet Yeu cau Sach";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NhanVienMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VeTrangDangNhap);
            this.Controls.Add(this.ThongTinCaNhan);
            this.Name = "NhanVienMenu";
            this.Text = "NhanVienMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private void SetUp()
        {
            if (CongCu.LoaiUser != UserType.Admin)
            {
                button1.Hide();
            }
        }

        private System.Windows.Forms.Button ThongTinCaNhan;
        private System.Windows.Forms.Button VeTrangDangNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}