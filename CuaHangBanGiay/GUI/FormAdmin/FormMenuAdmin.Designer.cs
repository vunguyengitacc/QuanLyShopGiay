
namespace CuaHangBanGiay.GUI.FormAdmin
{
    partial class FormMenuAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnNhapKho
            // 
            this.btnnNhapKho.BackColor = System.Drawing.Color.Lime;
            this.btnnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnNhapKho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnNhapKho.Location = new System.Drawing.Point(58, 130);
            this.btnnNhapKho.Name = "btnnNhapKho";
            this.btnnNhapKho.Size = new System.Drawing.Size(566, 104);
            this.btnnNhapKho.TabIndex = 6;
            this.btnnNhapKho.Text = "Tạo Tài Khoản";
            this.btnnNhapKho.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(58, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(566, 104);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quản Lý Tài Khoản";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnNhapKho);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnNhapKho;
        private System.Windows.Forms.Button button1;
    }
}