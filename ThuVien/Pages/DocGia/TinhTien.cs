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
    public partial class TinhTien : Form
    {
        public TinhTien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datSach = new DatSach();
            Hide();
            datSach.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private double TienMuonSach(DateTime ngayMuon, DateTime ngayTra)
        {
            int validNgayMuon = DateTime.Compare(DateTime.Now, ngayMuon);
            if (validNgayMuon > 0)
            {
                return 0;
            }
            else
            {
                int res = DateTime.Compare(ngayMuon, ngayTra);
                if (res > 0)
                {
                    return 0;
                }
                else
                {
                    TimeSpan diffResult = ngayTra.Subtract(ngayMuon);
                    return (diffResult.Days * 1000 + 20000);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var datSach = new DatSach();
            Hide();
            datSach.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tien = TienMuonSach(dateTimePicker1.Value, dateTimePicker2.Value);
            if (tien <= 0)
            {
                MessageBox.Show("Ngay Muon phai co gia tri hon thoi diem hien tai va it hon Ngay Tra");
            }
            else
            {
                label8.Show();
                button2.Show();
                label8.Text = tien.ToString();
                CongCu.myContext.YeuCauSachs.Add(new Database.Model.YeuCauSach()
                {
                    sMaDocGia = CongCu.CurrentDocGia.sMaDocGia,
                    sMaSach = CongCu.CurrentSach.sMaSach,
                    dNgayMuon = dateTimePicker1.Value,
                    dNgayTra = dateTimePicker2.Value,
                    sTrangThai = Database.Enum.TrangThai.ChoQuyetDinh,
                    fGiaThue = tien
                });

                CongCu.myContext.SaveChanges();
            }
        }
    }
}
