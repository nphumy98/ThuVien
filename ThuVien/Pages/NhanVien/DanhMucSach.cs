using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.NhanVien
{
    public partial class DanhMucSach : Form
    {
        public DanhMucSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nhanVienMenu = new NhanVienMenu();
            Hide();
            nhanVienMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Thong Tin Chi Tiet")
            {
                int row = this.dataGridView1.CurrentCell.RowIndex;
                CongCu.CurrentSach = toanBoSach[row];
                Hide();
                var lichSuSach = new LichSuSach();
                lichSuSach.Show();
            }
        }
    }
}
