namespace _31_731_LeBuiThienDuc_Tuan04
{
    partial class BTNC
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
            this.lst_Xuat = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXoaPTChon = new System.Windows.Forms.Button();
            this.BtnSon = new System.Windows.Forms.Button();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnTHuong = new System.Windows.Forms.Button();
            this.BTNHoaDau = new System.Windows.Forms.Button();
            this.BTnXoaALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Xuat
            // 
            this.lst_Xuat.FormattingEnabled = true;
            this.lst_Xuat.Location = new System.Drawing.Point(12, 80);
            this.lst_Xuat.Name = "lst_Xuat";
            this.lst_Xuat.Size = new System.Drawing.Size(219, 316);
            this.lst_Xuat.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 30);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(219, 23);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập Tên Ngẫu Nhiên";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXoaPTChon
            // 
            this.btnXoaPTChon.Location = new System.Drawing.Point(237, 63);
            this.btnXoaPTChon.Name = "btnXoaPTChon";
            this.btnXoaPTChon.Size = new System.Drawing.Size(233, 23);
            this.btnXoaPTChon.TabIndex = 1;
            this.btnXoaPTChon.Text = "Xóa Phần Tử Đang Chọn";
            this.btnXoaPTChon.UseVisualStyleBackColor = true;
            this.btnXoaPTChon.Click += new System.EventHandler(this.btnXoaPTChon_Click);
            // 
            // BtnSon
            // 
            this.BtnSon.Location = new System.Drawing.Point(237, 109);
            this.BtnSon.Name = "BtnSon";
            this.BtnSon.Size = new System.Drawing.Size(233, 23);
            this.BtnSon.TabIndex = 1;
            this.BtnSon.Text = "Xóa Tên Sơn";
            this.BtnSon.UseVisualStyleBackColor = true;
            this.BtnSon.Click += new System.EventHandler(this.BtnSon_Click);
            // 
            // btnHoa
            // 
            this.btnHoa.Location = new System.Drawing.Point(237, 209);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(233, 23);
            this.btnHoa.TabIndex = 1;
            this.btnHoa.Text = "Chuyển thành Hoa";
            this.btnHoa.UseVisualStyleBackColor = true;
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(237, 156);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(233, 23);
            this.btnLe.TabIndex = 1;
            this.btnLe.Text = "Xóa Họ Lê";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnTHuong
            // 
            this.btnTHuong.Location = new System.Drawing.Point(237, 266);
            this.btnTHuong.Name = "btnTHuong";
            this.btnTHuong.Size = new System.Drawing.Size(233, 23);
            this.btnTHuong.TabIndex = 1;
            this.btnTHuong.Text = "Chuyển Thành Thường";
            this.btnTHuong.UseVisualStyleBackColor = true;
            // 
            // BTNHoaDau
            // 
            this.BTNHoaDau.Location = new System.Drawing.Point(237, 321);
            this.BTNHoaDau.Name = "BTNHoaDau";
            this.BTNHoaDau.Size = new System.Drawing.Size(233, 23);
            this.BTNHoaDau.TabIndex = 1;
            this.BTNHoaDau.Text = "Viết Hoa đầu mỗi từ";
            this.BTNHoaDau.UseVisualStyleBackColor = true;
            // 
            // BTnXoaALL
            // 
            this.BTnXoaALL.Location = new System.Drawing.Point(237, 373);
            this.BTnXoaALL.Name = "BTnXoaALL";
            this.BTnXoaALL.Size = new System.Drawing.Size(233, 23);
            this.BTnXoaALL.TabIndex = 1;
            this.BTnXoaALL.Text = "Xóa Tất Cả các Phần tử";
            this.BTnXoaALL.UseVisualStyleBackColor = true;
            this.BTnXoaALL.Click += new System.EventHandler(this.BTnXoaALL_Click);
            // 
            // BTNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 408);
            this.Controls.Add(this.btnLe);
            this.Controls.Add(this.BTnXoaALL);
            this.Controls.Add(this.BTNHoaDau);
            this.Controls.Add(this.btnTHuong);
            this.Controls.Add(this.btnHoa);
            this.Controls.Add(this.BtnSon);
            this.Controls.Add(this.btnXoaPTChon);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lst_Xuat);
            this.Name = "BTNC";
            this.Text = "BTNC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Xuat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoaPTChon;
        private System.Windows.Forms.Button BtnSon;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnTHuong;
        private System.Windows.Forms.Button BTNHoaDau;
        private System.Windows.Forms.Button BTnXoaALL;
    }
}