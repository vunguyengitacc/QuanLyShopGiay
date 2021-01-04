using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuaHangBanGiay.GUI.FormQuanLyBanHang
{
    public partial class FormQuanLyShop : Form
    {
        public FormQuanLyShop()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.None;
        }

        private void btnnLapHoaDon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            FormLapHoaDon frm = new FormLapHoaDon();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is FormLapHoaDon)
                {
                    panel1.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();

        }

        private void FormQuanLyShop_Load(object sender, EventArgs e)
        {

        }

        private void btnDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            FormDanhSachHoaDon frm = new FormDanhSachHoaDon();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is FormDanhSachHoaDon)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {

            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            FormDanhSachKhachHang frm = new FormDanhSachKhachHang();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is FormDanhSachKhachHang)
                {
                    panel1.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
            
        }
    }
}
