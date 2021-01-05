
namespace CuaHangBanGiay.GUI.FormQuanLyBanHang
{
    partial class FormQuanLyShop
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
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btnDanhSachHoaDon = new System.Windows.Forms.Button();
            this.btnnLapHoaDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.btnDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(50, 369);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(566, 104);
            this.btnDanhSachKhachHang.TabIndex = 11;
            this.btnDanhSachKhachHang.Text = "Danh Sách Khách Hàng";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // btnDanhSachHoaDon
            // 
            this.btnDanhSachHoaDon.BackColor = System.Drawing.Color.Green;
            this.btnDanhSachHoaDon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachHoaDon.Location = new System.Drawing.Point(50, 230);
            this.btnDanhSachHoaDon.Name = "btnDanhSachHoaDon";
            this.btnDanhSachHoaDon.Size = new System.Drawing.Size(566, 104);
            this.btnDanhSachHoaDon.TabIndex = 10;
            this.btnDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            this.btnDanhSachHoaDon.UseVisualStyleBackColor = false;
            this.btnDanhSachHoaDon.Click += new System.EventHandler(this.btnDanhSachHoaDon_Click);
            // 
            // btnnLapHoaDon
            // 
            this.btnnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnLapHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnLapHoaDon.Location = new System.Drawing.Point(50, 97);
            this.btnnLapHoaDon.Name = "btnnLapHoaDon";
            this.btnnLapHoaDon.Size = new System.Drawing.Size(566, 104);
            this.btnnLapHoaDon.TabIndex = 9;
            this.btnnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnnLapHoaDon.Click += new System.EventHandler(this.btnnLapHoaDon_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(40, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 8;
            // 
            // FormQuanLyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(672, 511);
            this.Controls.Add(this.btnDanhSachKhachHang);
            this.Controls.Add(this.btnDanhSachHoaDon);
            this.Controls.Add(this.btnnLapHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyShop";
            this.Text = "FormQuanLyShop";
            this.Load += new System.EventHandler(this.FormQuanLyShop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnDanhSachHoaDon;
        private System.Windows.Forms.Button btnnLapHoaDon;
        private System.Windows.Forms.Panel panel1;
    }
}