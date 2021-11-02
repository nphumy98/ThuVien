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
            SetUp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var danhSachDocGia = new DanhSachDocGia();
            danhSachDocGia.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
