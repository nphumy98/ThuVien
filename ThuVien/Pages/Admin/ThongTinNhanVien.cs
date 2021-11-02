using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.Admin
{
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
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
            CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sTenNhanVien = textBox1.Text;
            CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sQueQuan = textBox2.Text;
            CongCu.myContext.ThuThus.Where(x => x.sMaNhanVien == CongCu.CurrentNhanVien.sMaNhanVien).ToList().FirstOrDefault().sDiaChi = textBox3.Text;
            CongCu.myContext.SaveChanges();
            CongCu.CurrentNhanVien = CongCu.CurrentAdmin;
            var nhanVienMenu = new NhanVienMenu();
            Hide();
            nhanVienMenu.Show();

        }
    }
}
