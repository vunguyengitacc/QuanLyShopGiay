
namespace CuaHangBanGiay.GUI.FormKho
{
    partial class FormQuanLyKho
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
            this.btnnNhapKho = new System.Windows.Forms.Button();
            this.btnDanhSachHangTon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnnNhapKho
            // 
            this.btnnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnNhapKho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnNhapKho.Location = new System.Drawing.Point(54, 128);
            this.btnnNhapKho.Name = "btnnNhapKho";
            this.btnnNhapKho.Size = new System.Drawing.Size(566, 104);
            this.btnnNhapKho.TabIndex = 5;
            this.btnnNhapKho.Text = "Nhập Kho";
            this.btnnNhapKho.UseVisualStyleBackColor = false;
            this.btnnNhapKho.Click += new System.EventHandler(this.btnnNhapKho_Click);
            // 
            // btnDanhSachHangTon
            // 
            this.btnDanhSachHangTon.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDanhSachHangTon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHangTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHangTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHangTon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhSachHangTon.Location = new System.Drawing.Point(54, 290);
            this.btnDanhSachHangTon.Name = "btnDanhSachHangTon";
            this.btnDanhSachHangTon.Size = new System.Drawing.Size(566, 104);
            this.btnDanhSachHangTon.TabIndex = 6;
            this.btnDanhSachHangTon.Text = "Danh Sách Hàng Tồn Kho";
            this.btnDanhSachHangTon.UseVisualStyleBackColor = false;
            this.btnDanhSachHangTon.Click += new System.EventHandler(this.btnDanhSachHangTon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(24, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 7;
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 511);
            this.Controls.Add(this.btnnNhapKho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDanhSachHangTon);
            this.Name = "FormQuanLyKho";
            this.Text = "FormNhapKho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnNhapKho;
        private System.Windows.Forms.Button btnDanhSachHangTon;
        private System.Windows.Forms.Panel panel1;
    }
}