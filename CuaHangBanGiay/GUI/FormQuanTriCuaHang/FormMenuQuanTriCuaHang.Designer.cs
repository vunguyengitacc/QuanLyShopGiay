
namespace CuaHangBanGiay.GUI.FormQuanTriCuaHang
{
    partial class FormMenuQuanTriCuaHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 23);
            this.panel1.TabIndex = 10;
            // 
            // btnnQuanLyNhanVien
            // 
            this.btnnQuanLyNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnQuanLyNhanVien.Location = new System.Drawing.Point(51, 144);
            this.btnnQuanLyNhanVien.Name = "btnnQuanLyNhanVien";
            this.btnnQuanLyNhanVien.Size = new System.Drawing.Size(566, 104);
            this.btnnQuanLyNhanVien.TabIndex = 9;
            this.btnnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnnQuanLyNhanVien.Click += new System.EventHandler(this.btnnQuanLyNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(51, 299);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(566, 104);
            this.btnThongKe.TabIndex = 11;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // FormMenuQuanTriCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(672, 511);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnQuanLyNhanVien);
            this.Name = "FormMenuQuanTriCuaHang";
            this.Text = "FormQuanTriCuaHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnQuanLyNhanVien;
        private System.Windows.Forms.Button btnThongKe;
    }
}