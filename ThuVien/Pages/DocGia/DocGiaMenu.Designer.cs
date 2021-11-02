
namespace ThuVien.Pages
{
    partial class DocGiaMenu
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
            this.SachMuon = new System.Windows.Forms.Button();
            this.DatSach = new System.Windows.Forms.Button();
            this.ThongTinCaNhan = new System.Windows.Forms.Button();
            this.DangNhapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SachMuon
            // 
            this.SachMuon.Location = new System.Drawing.Point(272, 79);
            this.SachMuon.Name = "SachMuon";
            this.SachMuon.Size = new System.Drawing.Size(132, 61);
            this.SachMuon.TabIndex = 0;
            this.SachMuon.Text = "Sach Muon";
            this.SachMuon.UseVisualStyleBackColor = true;
            this.SachMuon.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatSach
            // 
            this.DatSach.Location = new System.Drawing.Point(272, 177);
            this.DatSach.Name = "DatSach";
            this.DatSach.Size = new System.Drawing.Size(132, 60);
            this.DatSach.TabIndex = 1;
            this.DatSach.Text = "Dat Sach";
            this.DatSach.UseVisualStyleBackColor = true;
            this.DatSach.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThongTinCaNhan
            // 
            this.ThongTinCaNhan.Location = new System.Drawing.Point(272, 275);
            this.ThongTinCaNhan.Name = "ThongTinCaNhan";
            this.ThongTinCaNhan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ThongTinCaNhan.Size = new System.Drawing.Size(132, 56);
            this.ThongTinCaNhan.TabIndex = 2;
            this.ThongTinCaNhan.Text = "Thong Tin Ca Nhan";
            this.ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.ThongTinCaNhan.Click += new System.EventHandler(this.ThongTinCaNhan_Click);
            // 
            // DangNhapButton
            // 
            this.DangNhapButton.Location = new System.Drawing.Point(272, 377);
            this.DangNhapButton.Name = "DangNhapButton";
            this.DangNhapButton.Size = new System.Drawing.Size(132, 61);
            this.DangNhapButton.TabIndex = 3;
            this.DangNhapButton.Text = "Ve Trang Dang Nhap";
            this.DangNhapButton.UseVisualStyleBackColor = true;
            this.DangNhapButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // DocGiaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DangNhapButton);
            this.Controls.Add(this.ThongTinCaNhan);
            this.Controls.Add(this.DatSach);
            this.Controls.Add(this.SachMuon);
            this.Name = "DocGiaMenu";
            this.Text = "DocGiaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SachMuon;
        private System.Windows.Forms.Button DatSach;
        private System.Windows.Forms.Button ThongTinCaNhan;
        private System.Windows.Forms.Button DangNhapButton;
    }
}