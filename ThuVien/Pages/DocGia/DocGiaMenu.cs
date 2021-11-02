using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Pages.DocGia;

namespace ThuVien.Pages
{
    public partial class DocGiaMenu : Form
    {
        public DocGiaMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var datSach = new DatSach();
            Hide();
            datSach.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dangNhap = new DangNhap();
            Hide();
            dangNhap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sachMuon = new SachMuon();
            Hide();
            sachMuon.Show();
        }

        private void ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            var thongTinCaNhan = new ThongTinCaNhan();
            Hide();
            thongTinCaNhan.Show();
        }
    }
}
