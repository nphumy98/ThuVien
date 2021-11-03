using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.NhanVien
{
    public partial class DanhSachDocGia : Form
    {
        public DanhSachDocGia()
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
            int row = this.dataGridView1.CurrentCell.RowIndex;
            CongCu.CurrentDocGia = docGias[row];
            Hide();
            var lichsuDocGia = new LichSuDocGia();
            lichsuDocGia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loaiTimKiem = ChonTimKiem();
            var ketQuaTimKiem = new List<Database.Model.DocGia>();
            if (loaiTimKiem == "ten")
            {
                ketQuaTimKiem = docGias.Where(x => x.sTenDocGia.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else if (loaiTimKiem == "dia chi")
            {
                ketQuaTimKiem = docGias.Where(x => x.sDiaChi.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else
            {
                ketQuaTimKiem = docGias;
            }
            DataTable dtb = CongCu.ToDataTable(ketQuaTimKiem);

            dataGridView1.DataSource = dtb;

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            buttons.UseColumnTextForButtonValue = true;
            buttons.Text = "Chon Doc Gia";
            buttons.Name = "Thong Tin Chi Tiet";
            dataGridView1.Columns.Add(buttons);
        }

        private string ChonTimKiem()
        {
            if (comboBox1.SelectedItem == null || String.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                return "";
            }
            else if (comboBox1.SelectedItem.ToString().ToLower().Contains("ten"))
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
