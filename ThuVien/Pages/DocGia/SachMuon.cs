using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.DocGia
{
    public partial class SachMuon : Form
    {
        public SachMuon()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
