using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.DocGia
{
    public partial class DangKyDocGia : Form
    {
        public DangKyDocGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                CongCu.myContext.DocGias.Add(new Database.Model.DocGia()
                {
                    sTenDocGia = textBox1.Text,
                    sGioiTinh = Database.Enum.GioiTinh.Nam,
                    sUser = textBox1.Text,
                    sQueQuan = textBox2.Text,
                    sDiaChi = textBox3.Text,
                    sPassword = textBox4.Text,
                    sNgaySinh = dateTimePicker1.Value,
                    dNgayLapThe = DateTime.Now,
                    sNgayHetHan = DateTime.Now.AddYears(2)
                });
                CongCu.myContext.SaveChanges();
                MessageBox.Show($"Tai Khoan Doc Gia {textBox1.Text} da duoc dang ky");
            }
            else
            {
                MessageBox.Show($"Ban phai dien het thong tin de dang ky tai khoan");
            }

            Hide();
            var dangNhap = new DangNhap();
            dangNhap.Show();
        }


        private bool Validate()
        {
            return !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
