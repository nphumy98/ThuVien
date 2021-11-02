using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.Admin
{
    public partial class DangKyNhanVien : Form
    {
        public DangKyNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CongCu.CurrentNhanVien = CongCu.CurrentAdmin;
            var danhSachNhanVien = new DanhSachNhanVien();
            Hide();
            danhSachNhanVien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                CongCu.myContext.ThuThus.Add(new Database.Model.ThuThu()
                {
                    sTenNhanVien = textBox1.Text,
                    sGioiTinh = Database.Enum.GioiTinh.Nam,
                    sUser = textBox1.Text,
                    sQueQuan = textBox2.Text,
                    sDiaChi = textBox3.Text,
                    sPassword = textBox4.Text,
                    cChucVu = Database.Enum.ChucVu.NhanVien,
                    dNgayVaoLam = DateTime.Now,
                    sSDT = "0924125532"
                });
                CongCu.myContext.SaveChanges();
                MessageBox.Show($"Tai Khoan Nhan Vien {textBox1.Text} da duoc dang ky");
            }
            else
            {
                MessageBox.Show($"Ban phai dien het thong tin de dang ky tai khoan");
            }

            Hide();
            var dangKyNhanVien = new DangKyNhanVien();
            dangKyNhanVien.Show();
        }

        private bool Validate()
        {
            return !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
