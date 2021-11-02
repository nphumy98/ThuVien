
using Database.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ThuVien.Helpers;

namespace ThuVien.Pages.NhanVien
{
    partial class XetDuyetYeuCauSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay Ve Trang Chinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(704, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // XetDuyetYeuCauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "XetDuyetYeuCauSach";
            this.Text = "XetDuyetYeuCauSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            SetUp();
        }

        #endregion
        private void SetUp()
        {
            yeuCauSach = CongCu.myContext.YeuCauSachs.ToList();
            DataTable dtb = CongCu.ToDataTable(yeuCauSach);
            //dtb.Columns.RemoveAt(9);
            //dtb.Columns.RemoveAt(8);
            // dtb.Columns.RemoveAt(7);
            //dtb.Columns.RemoveAt(6);
            dataGridView1.DataSource = dtb;

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            buttons.UseColumnTextForButtonValue = true;
            buttons.Text = "Chap Thuan";
            buttons.Name = "Quyet Dinh";
            dataGridView1.Columns.Add(buttons);
        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private List<YeuCauSach> yeuCauSach;
    }
}