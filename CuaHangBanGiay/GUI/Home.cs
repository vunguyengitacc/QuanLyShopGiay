using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangBanGiay.GUI.FormKho;
using CuaHangBanGiay.GUI.FormQuanLyBanHang;
using CuaHangBanGiay.GUI.FormAdmin;

namespace CuaHangBanGiay.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void resetColor(Panel pannelVar)
        {
            foreach (Button item in pannelVar.Controls)
            {
                item.BackColor = Color.DarkViolet;
                item.ForeColor = Color.White;
            }
        }

        private void setClickEventButton(Button btn)
        {
            foreach (object item in panel1.Controls)
            {
                if (item is Panel)
                {
                    resetColor((Panel)item);
                }
            }
            
            btn.ForeColor = Color.DarkViolet;
            btn.BackColor = Color.FromArgb(249,249,249);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }





        private void pnlNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            setClickEventButton(btnQuanLyBanHang);
            FormQuanLyKho frm = new FormQuanLyKho();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyKho)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            setClickEventButton(btnQuanLyKho);
            FormQuanLyShop frm = new FormQuanLyShop();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyShop)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            setClickEventButton(btnAdmin);
            FormMenuAdmin frm = new FormMenuAdmin();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormMenuAdmin)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}
