using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanGiay.GUI.FormAdmin
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnnNhapKho_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            foreach (Form item in panel1.Controls)
            {
                if (item is FormThemTaiKhoan)
                {
                    item.BringToFront();
                    return;
                }
            }
            FormThemTaiKhoan frm = new FormThemTaiKhoan();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            foreach (Form item in panel1.Controls)
            {
                if (item is FormQuanLyTaiKhoan)
                {
                    item.BringToFront();
                    return;
                }
            }
            FormQuanLyTaiKhoan frm = new FormQuanLyTaiKhoan();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}
