
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
            this.SuspendLayout();
            // 
            // ThongTinCaNhan
            // 
            this.ThongTinCaNhan.Location = new System.Drawing.Point(291, 246);
            this.ThongTinCaNhan.Name = "ThongTinCaNhan";
            this.ThongTinCaNhan.Size = new System.Drawing.Size(118, 50);
            this.ThongTinCaNhan.TabIndex = 0;
            this.ThongTinCaNhan.Text = "Thong Tin Ca Nhan";
            this.ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.ThongTinCaNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // VeTrangDangNhap
            // 
            this.VeTrangDangNhap.Location = new System.Drawing.Point(291, 318);
            this.VeTrangDangNhap.Name = "VeTrangDangNhap";
            this.VeTrangDangNhap.Size = new System.Drawing.Size(118, 55);
            this.VeTrangDangNhap.TabIndex = 1;
            this.VeTrangDangNhap.Text = "Ve Trang Dang Nhap";
            this.VeTrangDangNhap.UseVisualStyleBackColor = true;
            this.VeTrangDangNhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // NhanVienMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VeTrangDangNhap);
            this.Controls.Add(this.ThongTinCaNhan);
            this.Name = "NhanVienMenu";
            this.Text = "NhanVienMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThongTinCaNhan;
        private System.Windows.Forms.Button VeTrangDangNhap;
    }
}