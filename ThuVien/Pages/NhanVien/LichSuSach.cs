using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.Pages.NhanVien
{
    public partial class LichSuSach : Form
    {
        public LichSuSach()
        {
            InitializeComponent();
            SetUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var danhMucSach = new DanhMucSach();
            danhMucSach.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
