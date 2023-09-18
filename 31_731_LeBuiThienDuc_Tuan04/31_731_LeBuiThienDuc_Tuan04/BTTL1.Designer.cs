namespace _31_731_LeBuiThienDuc_Tuan04
{
    partial class BTTL1
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
            this.GBNhp = new System.Windows.Forms.GroupBox();
            this.cb_So = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstUoc = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSoUocCHan = new System.Windows.Forms.Button();
            this.btnNguyenToLe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.GBNhp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBNhp
            // 
            this.GBNhp.Controls.Add(this.cb_So);
            this.GBNhp.Controls.Add(this.btnNhap);
            this.GBNhp.Controls.Add(this.txtNhap);
            this.GBNhp.Location = new System.Drawing.Point(21, 12);
            this.GBNhp.Name = "GBNhp";
            this.GBNhp.Size = new System.Drawing.Size(207, 133);
            this.GBNhp.TabIndex = 0;
            this.GBNhp.TabStop = false;
            this.GBNhp.Text = "Nhap So";
            // 
            // cb_So
            // 
            this.cb_So.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_So.FormattingEnabled = true;
            this.cb_So.Location = new System.Drawing.Point(15, 70);
            this.cb_So.Name = "cb_So";
            this.cb_So.Size = new System.Drawing.Size(186, 21);
            this.cb_So.TabIndex = 2;
            this.cb_So.SelectedIndexChanged += new System.EventHandler(this.cb_So_SelectedIndexChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(126, 27);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Cap Nhat";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(15, 29);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 20);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUoc);
            this.groupBox1.Location = new System.Drawing.Point(286, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Cac Uoc So";
            // 
            // lstUoc
            // 
            this.lstUoc.FormattingEnabled = true;
            this.lstUoc.Location = new System.Drawing.Point(6, 19);
            this.lstUoc.Name = "lstUoc";
            this.lstUoc.Size = new System.Drawing.Size(195, 108);
            this.lstUoc.TabIndex = 3;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(286, 180);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(207, 23);
            this.btnTong.TabIndex = 1;
            this.btnTong.Text = "&Tong Cac Uoc So";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSoUocCHan
            // 
            this.btnSoUocCHan.Location = new System.Drawing.Point(286, 209);
            this.btnSoUocCHan.Name = "btnSoUocCHan";
            this.btnSoUocCHan.Size = new System.Drawing.Size(207, 23);
            this.btnSoUocCHan.TabIndex = 1;
            this.btnSoUocCHan.Text = "So Luong Cac Uoc Chan";
            this.btnSoUocCHan.UseVisualStyleBackColor = true;
            this.btnSoUocCHan.Click += new System.EventHandler(this.btnSoUocCHan_Click);
            // 
            // btnNguyenToLe
            // 
            this.btnNguyenToLe.Location = new System.Drawing.Point(286, 238);
            this.btnNguyenToLe.Name = "btnNguyenToLe";
            this.btnNguyenToLe.Size = new System.Drawing.Size(207, 23);
            this.btnNguyenToLe.TabIndex = 1;
            this.btnNguyenToLe.Text = "So Luong Cac Uoc Nguyen To Le";
            this.btnNguyenToLe.UseVisualStyleBackColor = true;
            this.btnNguyenToLe.Click += new System.EventHandler(this.btnNguyenToLe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(286, 267);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(207, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BTTL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 314);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguyenToLe);
            this.Controls.Add(this.btnSoUocCHan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBNhp);
            this.Name = "BTTL1";
            this.Text = "BTTL1";
            this.GBNhp.ResumeLayout(false);
            this.GBNhp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNhp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.ComboBox cb_So;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ListBox lstUoc;
        private System.Windows.Forms.Button btnSoUocCHan;
        private System.Windows.Forms.Button btnNguyenToLe;
        private System.Windows.Forms.Button btnThoat;
    }
}