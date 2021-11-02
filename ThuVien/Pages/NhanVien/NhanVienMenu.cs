using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.Pages
{
    public partial class NhanVienMenu : Form
    {
        public NhanVienMenu()
        {
            InitializeComponent();
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
    }
}
