using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages
{
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
            SetUpThongTin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            if (CongCu.LoaiUser == UserType.DocGia)
            {
                var docGiaMenu = new DocGiaMenu();
                docGiaMenu.Show();
            }
            else
            {
                var nhanVienMenu = new NhanVienMenu();
                nhanVienMenu.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateThongTin_Click(object sender, EventArgs e)
        {
            if (CongCu.LoaiUser == UserType.DocGia)
            {
                CongCu.myContext.DocGias.Where(x => x.sMaDocGia == CongCu.CurrentDocGia.sMaDocGia).ToList().FirstOrDefault().sTenDocGia = textBox1.Text;
                CongCu.myContext.DocGias.Where(x => x.sMaDocGia == CongCu.CurrentDocGia.sMaDocGia).ToList().FirstOrDefault().sQueQuan = textBox2.Text;
                CongCu.myContext.DocGias.Where(x => x.sMaDocGia == CongCu.CurrentDocGia.sMaDocGia).ToList().FirstOrDefault().sDiaChi = textBox3.Text;
                CongCu.myContext.SaveChanges();
                var docGiaMenu = new DocGiaMenu();
                Hide();
                docGiaMenu.Show();
            }
            else
            {
                CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sTenNhanVien = textBox1.Text;
                CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sQueQuan = textBox2.Text;
                CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sDiaChi = textBox3.Text;
                CongCu.myContext.SaveChanges();
                var nhanVienMenu = new NhanVienMenu();
                Hide();
                nhanVienMenu.Show();
            }
            
        }
    }
}
