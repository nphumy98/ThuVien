using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Pages.Admin;
using ThuVien.Pages.NhanVien;

namespace ThuVien.Pages
{
    public partial class NhanVienMenu : Form
    {
        public NhanVienMenu()
        {
            InitializeComponent();
            SetUp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dangNhap = new DangNhap();
            Hide();
            dangNhap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thongTinCaNhan = new ThongTinCaNhan();
            Hide();
            thongTinCaNhan.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var danhSachNhanVien = new DanhSachNhanVien();
            Hide();
            danhSachNhanVien.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            var danhSachDocGia = new DanhSachDocGia();
            danhSachDocGia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            var danhMucSach = new DanhMucSach();
            danhMucSach.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            var xetDuyetYeuCauSach = new XetDuyetYeuCauSach();
            xetDuyetYeuCauSach.Show();
        }
    }
}
