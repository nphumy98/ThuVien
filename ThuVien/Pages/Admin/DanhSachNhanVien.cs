using Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.Admin
{
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();

            SetUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nhanVienMenu = new NhanVienMenu();
            Hide();
            nhanVienMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xem Thong Tin")
            {
                int row = this.dataGridView1.CurrentCell.RowIndex;
                CongCu.CurrentNhanVien = nhanVien[row];
                Hide();
                var thongTinNhanVien = new ThongTinNhanVien();
                thongTinNhanVien.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dangKyNhanVien = new DangKyNhanVien();
            Hide();
            dangKyNhanVien.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loaiTimKiem = ChonTimKiem();
            var ketQuaTimKiem = new List<ThuThu>();
            if (loaiTimKiem == "ten")
            {
                ketQuaTimKiem = nhanVien.Where(x => x.sTenNhanVien.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else if (loaiTimKiem == "dia chi")
            {
                ketQuaTimKiem = nhanVien.Where(x => x.sDiaChi.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else
            {
                ketQuaTimKiem = nhanVien;
            }    
            DataTable dtb = CongCu.ToDataTable(ketQuaTimKiem);

            dataGridView1.DataSource = dtb;

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            buttons.UseColumnTextForButtonValue = true;
            buttons.Text = "Chon Nhan Vien";
            buttons.Name = "Xem Thong Tin";
            dataGridView1.Columns.Add(buttons);
        }

        private string ChonTimKiem()
        {
            if (comboBox1.SelectedItem == null||String.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString())) 
            {
                return "";
            }
            else if(comboBox1.SelectedItem.ToString().ToLower().Contains("ten"))
            {
                return "ten";
            }
            else
            {
                return "dia chi";
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
