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
            Hide();
            var dangKyNhanVien = new DangKyNhanVien();
            dangKyNhanVien.Show();
        }
    }
}
