
using ThuVien.Helpers;

namespace ThuVien.Pages
{
    partial class ThongTinCaNhan
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
            this.QuayVeTrangChinh = new System.Windows.Forms.Button();
            this.UpdateThongTin = new System.Windows.Forms.Button();
            this.TenTuoi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuayVeTrangChinh
            // 
            this.QuayVeTrangChinh.Location = new System.Drawing.Point(190, 338);
            this.QuayVeTrangChinh.Name = "QuayVeTrangChinh";
            this.QuayVeTrangChinh.Size = new System.Drawing.Size(105, 43);
            this.QuayVeTrangChinh.TabIndex = 0;
            this.QuayVeTrangChinh.Text = "Quay Ve Trang Chinh";
            this.QuayVeTrangChinh.UseVisualStyleBackColor = true;
            this.QuayVeTrangChinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateThongTin
            // 
            this.UpdateThongTin.Location = new System.Drawing.Point(351, 338);
            this.UpdateThongTin.Name = "UpdateThongTin";
            this.UpdateThongTin.Size = new System.Drawing.Size(96, 43);
            this.UpdateThongTin.TabIndex = 1;
            this.UpdateThongTin.Text = "Update Thong Tin";
            this.UpdateThongTin.UseVisualStyleBackColor = true;
            this.UpdateThongTin.Click += new System.EventHandler(this.UpdateThongTin_Click);
            // 
            // TenTuoi
            // 
            this.TenTuoi.AutoSize = true;
            this.TenTuoi.Location = new System.Drawing.Point(153, 124);
            this.TenTuoi.Name = "TenTuoi";
            this.TenTuoi.Size = new System.Drawing.Size(51, 15);
            this.TenTuoi.TabIndex = 2;
            this.TenTuoi.Text = "Ten Tuoi";
            this.TenTuoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thong Tin Ca Nhan";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Que quan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia Chi";
            this.label3.UseMnemonic = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TenTuoi);
            this.Controls.Add(this.UpdateThongTin);
            this.Controls.Add(this.QuayVeTrangChinh);
            this.Name = "ThongTinCaNhan";
            this.Text = "ThongTinCaNhan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetUpThongTin()
        {
            label1.Text = $"Thong Tin Ca Nhan {CongCu.LoaiUser.ToString()}";
            if (CongCu.LoaiUser == UserType.DocGia)
            {
                textBox1.Text = CongCu.CurrentDocGia.sTenDocGia;
                textBox2.Text = CongCu.CurrentDocGia.sQueQuan;
                textBox3.Text = CongCu.CurrentDocGia.sDiaChi;
            }
            else
            {
                textBox1.Text = CongCu.CurrentNhanVien.sTenNhanVien;
                textBox2.Text = CongCu.CurrentNhanVien.sQueQuan;
                textBox3.Text = CongCu.CurrentNhanVien.sDiaChi;
            }
                
        }

        #endregion

        private System.Windows.Forms.Button QuayVeTrangChinh;
        private System.Windows.Forms.Button UpdateThongTin;
        private System.Windows.Forms.Label TenTuoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}