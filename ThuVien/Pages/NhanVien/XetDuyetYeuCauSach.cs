using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.Pages.NhanVien
{
    public partial class XetDuyetYeuCauSach : Form
    {
        public XetDuyetYeuCauSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var nhanVienMenu = new NhanVienMenu();
            nhanVienMenu.Show();
        }
    }
}
