using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanGiay.GUI.FormQuanTriCuaHang
{
    public partial class FormMenuQuanTriCuaHang : Form
    {
        public FormMenuQuanTriCuaHang()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            FormThongKe frm = new FormThongKe();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is FormThongKe)
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

        private void btnnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            FormQuanLyNhanVien frm = new FormQuanLyNhanVien();
            foreach (Form frmItem in panel1.Controls)
            {
                if (frmItem is FormQuanLyNhanVien)
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
    }
}
