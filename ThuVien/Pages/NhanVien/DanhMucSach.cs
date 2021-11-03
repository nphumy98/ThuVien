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
    public partial class DanhMucSach : Form
    {
        public DanhMucSach()
        {
            InitializeComponent();
            SetUp();
            Load += new EventHandler(DanhMucSach_Load);
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

        private void button2_Click(object sender, EventArgs e)
        {
            var loaiTimKiem = ChonTimKiem();
            var ketQuaTimKiem = new List<Database.Model.Sach>();
            if (loaiTimKiem == "ten")
            {
                ketQuaTimKiem = toanBoSach.Where(x => x.sTenSach.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else if (loaiTimKiem == "tac gia")
            {
                ketQuaTimKiem = toanBoSach.Where(x => x.sTacGia.ToLower().Contains(textBox1.Text.ToLower()) == true).ToList();
            }
            else
            {
                ketQuaTimKiem = toanBoSach;
            }
            DataTable dtb = CongCu.ToDataTable(ketQuaTimKiem);

            dataGridView1.DataSource = dtb;

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            buttons.UseColumnTextForButtonValue = true;
            buttons.Text = "Chon Sach";
            buttons.Name = "Thong Tin Chi Tiet";
            dataGridView1.Columns.Add(buttons);

            for (int i = 0; i < ketQuaTimKiem.Count; i++)
            {
                var listSachTheMuon = CongCu.myContext.TheMuons.Where(x => x.sMaSach == ketQuaTimKiem[i].sMaSach).ToList();
                if (listSachTheMuon != null && listSachTheMuon.Count > 0)
                {
                    if (DateTime.Compare(DateTime.Now, listSachTheMuon[0].dNgayTra) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
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
                return "tac gia";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void DanhMucSach_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < toanBoSach.Count; i++)
            {
                var listSachTheMuon = CongCu.myContext.TheMuons.Where(x => x.sMaSach == toanBoSach[i].sMaSach).ToList();
                if (listSachTheMuon != null && listSachTheMuon.Count > 0)
                {
                    if (DateTime.Compare(DateTime.Now, listSachTheMuon[0].dNgayTra) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
