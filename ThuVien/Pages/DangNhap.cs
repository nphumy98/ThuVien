using Database;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ThuVien.Helpers;
using System.Text;
using System.Windows.Forms;
using ThuVien.Pages;

namespace ThuVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UserTypeComboBox.SelectedItem = null;
            UserTypeComboBox.SelectedText = "DocGia";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CongCu.LoaiUser = ChonUser();
            var dangNhapChinhXac = false;
            if (CongCu.LoaiUser == UserType.DocGia)
            {
                var docgias = CongCu.myContext.DocGias.AsQueryable().ToList();
                var docGiaList = docgias.Where(x => x.sUser == UserTextBox.Text && x.sPassword == PasswordTextBox.Text).ToList();
                dangNhapChinhXac = docGiaList.Any() == true ? true : false;
                if(dangNhapChinhXac)
                {
                    CongCu.CurrentDocGia = docGiaList[0];
                    var sachDoc = new DocGiaMenu();
                    Hide();
                    sachDoc.Show();
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau Hoac Ten Dang Nhap");
                }
            }
            else
            {
                var nhanviens = CongCu.myContext.ThuThus.AsQueryable().ToList();
                var nhanviensList = nhanviens.Where(x => x.sUser == UserTextBox.Text && x.sPassword == PasswordTextBox.Text).ToList();
                dangNhapChinhXac = nhanviensList.Any() == true ? true : false;
                if (dangNhapChinhXac)
                {
                    CongCu.CurrentNhanVien = nhanviensList[0];
                    var trangNhanVien = new NhanVienMenu();
                    Hide();
                    trangNhanVien.Show();
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau Hoac Ten Dang Nhap");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private UserType ChonUser()
        {
            if (UserTypeComboBox.SelectedItem == null || UserTypeComboBox.SelectedItem.ToString().ToLower().Contains("docgia"))
            {
                return UserType.DocGia;
            }
            else if (UserTypeComboBox.SelectedItem.ToString().ToLower().Contains("nhanvien"))
            {
                return UserType.NhanVien;
            }
            else
            {
                return UserType.Admin;
            }
        }
    }
}
