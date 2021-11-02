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
            
        }
    }
}
