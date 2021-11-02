using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.NhanVien
{
    public partial class XetDuyetYeuCauSach : Form
    {
        public XetDuyetYeuCauSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var nhanVienMenu = new NhanVienMenu();
            nhanVienMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quyet Dinh")
            {
                int row = this.dataGridView1.CurrentCell.RowIndex;
                CongCu.CurrentYeuCauSach = yeuCauSach[row];
                CongCu.myContext.TheMuons.Add(
                    new Database.Model.TheMuon()
                    {
                        sMaDocGia = CongCu.CurrentYeuCauSach.sMaDocGia,
                        sMaSach = CongCu.CurrentYeuCauSach.sMaSach,
                        dNgayMuon = CongCu.CurrentYeuCauSach.dNgayMuon,
                        dNgayTra = CongCu.CurrentYeuCauSach.dNgayTra,
                        sMaNhanVien = CongCu.CurrentNhanVien.sMaNhanVien,
                        fGiaThue = CongCu.CurrentYeuCauSach.fGiaThue
                    }
                 ) ;

                CongCu.myContext.YeuCauSachs.Where(x => x.sMaYeuCau == CongCu.CurrentYeuCauSach.sMaYeuCau).FirstOrDefault().sTrangThai = Database.Enum.TrangThai.ChapNhan;
                CongCu.myContext.SaveChanges();
                Hide();
                var xetDuyetYeuCauSach = new XetDuyetYeuCauSach();
                xetDuyetYeuCauSach.Show();
            }
        }
    }
}
