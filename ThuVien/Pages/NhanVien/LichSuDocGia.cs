using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.Pages.NhanVien
{
    public partial class LichSuDocGia : Form
    {
        public LichSuDocGia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var danhSachDocGia = new DanhSachDocGia();
            danhSachDocGia.Show();
        }
    }
}
