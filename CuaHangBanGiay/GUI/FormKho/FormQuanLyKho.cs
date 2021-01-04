using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanGiay.GUI.FormKho
{
    public partial class FormQuanLyKho : Form
    {
        public FormQuanLyKho()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.None;
        }

        private void btnnNhapKho_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            foreach(Form item in panel1.Controls)
            {
                if(item is FormNhapKho)
                {
                    item.BringToFront();
                    return;
                }
            }
            FormNhapKho frm = new FormNhapKho();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnDanhSachHangTon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            foreach (Form item in panel1.Controls)
            {
                if (item is FormDanhSachSanPham)
                {
                    item.BringToFront();
                    return;
                }
            }
            FormDanhSachSanPham frm = new FormDanhSachSanPham();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}
