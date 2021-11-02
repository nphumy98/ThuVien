using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;
using Database.Model;

namespace ThuVien.Pages.DocGia
{
    public partial class DatSach : Form
    {
        public DatSach()
        {
            InitializeComponent();

            SetUp();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Dat Sach")
            {
                int row = this.dataGridView1.CurrentCell.RowIndex;
                CongCu.CurrentSach = sachTrongKho[row];
                var tinhTien = new TinhTien();
                Hide();
                tinhTien.Show();
            }
        }
    }
}
