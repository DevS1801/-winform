namespace _31_731_LeBuiThienDuc_Tuan04
{
    partial class FrmBTVN1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Danh Sách Lớp");
            this.tr_Lop = new System.Windows.Forms.TreeView();
            this.Cb_Lop = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new MetroFramework.Controls.MetroButton();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.txt_DiaCHi = new MetroFramework.Controls.MetroTextBox();
            this.txt_HoTen = new MetroFramework.Controls.MetroTextBox();
            this.txt_Msv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chk_Add = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.txt_TenLop = new MetroFramework.Controls.MetroTextBox();
            this.labelTenLop = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tr_Lop
            // 
            this.tr_Lop.Location = new System.Drawing.Point(0, 0);
            this.tr_Lop.Name = "tr_Lop";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Danh Sách Lớp";
            this.tr_Lop.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tr_Lop.Size = new System.Drawing.Size(258, 451);
            this.tr_Lop.TabIndex = 0;
            this.tr_Lop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tr_Lop_AfterSelect);
            // 
            // Cb_Lop
            // 
            this.Cb_Lop.FormattingEnabled = true;
            this.Cb_Lop.ItemHeight = 24;
            this.Cb_Lop.Location = new System.Drawing.Point(440, 23);
            this.Cb_Lop.Name = "Cb_Lop";
            this.Cb_Lop.Size = new System.Drawing.Size(328, 30);
            this.Cb_Lop.TabIndex = 1;
            this.Cb_Lop.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.txt_DiaCHi);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_Msv);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(281, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(326, 210);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 32);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseSelectable = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(159, 210);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(91, 32);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_DiaCHi
            // 
            // 
            // 
            // 
            this.txt_DiaCHi.CustomButton.Image = null;
            this.txt_DiaCHi.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txt_DiaCHi.CustomButton.Name = "";
            this.txt_DiaCHi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_DiaCHi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_DiaCHi.CustomButton.TabIndex = 1;
            this.txt_DiaCHi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_DiaCHi.CustomButton.UseSelectable = true;
            this.txt_DiaCHi.CustomButton.Visible = false;
            this.txt_DiaCHi.Lines = new string[0];
            this.txt_DiaCHi.Location = new System.Drawing.Point(159, 157);
            this.txt_DiaCHi.MaxLength = 32767;
            this.txt_DiaCHi.Name = "txt_DiaCHi";
            this.txt_DiaCHi.PasswordChar = '\0';
            this.txt_DiaCHi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_DiaCHi.SelectedText = "";
            this.txt_DiaCHi.SelectionLength = 0;
            this.txt_DiaCHi.SelectionStart = 0;
            this.txt_DiaCHi.ShortcutsEnabled = true;
            this.txt_DiaCHi.Size = new System.Drawing.Size(322, 23);
            this.txt_DiaCHi.TabIndex = 1;
            this.txt_DiaCHi.UseSelectable = true;
            this.txt_DiaCHi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_DiaCHi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_HoTen
            // 
            // 
            // 
            // 
            this.txt_HoTen.CustomButton.Image = null;
            this.txt_HoTen.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txt_HoTen.CustomButton.Name = "";
            this.txt_HoTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_HoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_HoTen.CustomButton.TabIndex = 1;
            this.txt_HoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_HoTen.CustomButton.UseSelectable = true;
            this.txt_HoTen.CustomButton.Visible = false;
            this.txt_HoTen.Lines = new string[0];
            this.txt_HoTen.Location = new System.Drawing.Point(159, 94);
            this.txt_HoTen.MaxLength = 32767;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PasswordChar = '\0';
            this.txt_HoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.SelectionLength = 0;
            this.txt_HoTen.SelectionStart = 0;
            this.txt_HoTen.ShortcutsEnabled = true;
            this.txt_HoTen.Size = new System.Drawing.Size(322, 23);
            this.txt_HoTen.TabIndex = 1;
            this.txt_HoTen.UseSelectable = true;
            this.txt_HoTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_HoTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Msv
            // 
            // 
            // 
            // 
            this.txt_Msv.CustomButton.Image = null;
            this.txt_Msv.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txt_Msv.CustomButton.Name = "";
            this.txt_Msv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Msv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Msv.CustomButton.TabIndex = 1;
            this.txt_Msv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Msv.CustomButton.UseSelectable = true;
            this.txt_Msv.CustomButton.Visible = false;
            this.txt_Msv.Lines = new string[0];
            this.txt_Msv.Location = new System.Drawing.Point(159, 34);
            this.txt_Msv.MaxLength = 32767;
            this.txt_Msv.Name = "txt_Msv";
            this.txt_Msv.PasswordChar = '\0';
            this.txt_Msv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Msv.SelectedText = "";
            this.txt_Msv.SelectionLength = 0;
            this.txt_Msv.SelectionStart = 0;
            this.txt_Msv.ShortcutsEnabled = true;
            this.txt_Msv.Size = new System.Drawing.Size(322, 23);
            this.txt_Msv.TabIndex = 1;
            this.txt_Msv.UseSelectable = true;
            this.txt_Msv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Msv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Địa Chỉ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Họ Tên";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã SV";
            // 
            // chk_Add
            // 
            this.chk_Add.AutoSize = true;
            this.chk_Add.Location = new System.Drawing.Point(281, 361);
            this.chk_Add.Name = "chk_Add";
            this.chk_Add.Size = new System.Drawing.Size(82, 17);
            this.chk_Add.TabIndex = 3;
            this.chk_Add.Text = "Thêm Lớp";
            this.chk_Add.UseSelectable = true;
            this.chk_Add.CheckedChanged += new System.EventHandler(this.chk_Add_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txt_TenLop);
            this.groupBox2.Controls.Add(this.labelTenLop);
            this.groupBox2.Location = new System.Drawing.Point(272, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lớp";
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(380, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm Lớp";
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_TenLop
            // 
            // 
            // 
            // 
            this.txt_TenLop.CustomButton.Image = null;
            this.txt_TenLop.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txt_TenLop.CustomButton.Name = "";
            this.txt_TenLop.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TenLop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenLop.CustomButton.TabIndex = 1;
            this.txt_TenLop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenLop.CustomButton.UseSelectable = true;
            this.txt_TenLop.CustomButton.Visible = false;
            this.txt_TenLop.Enabled = false;
            this.txt_TenLop.Lines = new string[0];
            this.txt_TenLop.Location = new System.Drawing.Point(129, 31);
            this.txt_TenLop.MaxLength = 32767;
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.PasswordChar = '\0';
            this.txt_TenLop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenLop.SelectedText = "";
            this.txt_TenLop.SelectionLength = 0;
            this.txt_TenLop.SelectionStart = 0;
            this.txt_TenLop.ShortcutsEnabled = true;
            this.txt_TenLop.Size = new System.Drawing.Size(236, 23);
            this.txt_TenLop.TabIndex = 1;
            this.txt_TenLop.UseSelectable = true;
            this.txt_TenLop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenLop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Enabled = false;
            this.labelTenLop.Location = new System.Drawing.Point(24, 27);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(58, 20);
            this.labelTenLop.TabIndex = 0;
            this.labelTenLop.Text = "Tên Lớp";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(333, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Chọn Lớp";
            // 
            // FrmBTVN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chk_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cb_Lop);
            this.Controls.Add(this.tr_Lop);
            this.Name = "FrmBTVN1";
            this.Text = "Quản Lí Sinh Viên";
            this.Load += new System.EventHandler(this.FrmBTVN1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tr_Lop;
        private MetroFramework.Controls.MetroComboBox Cb_Lop;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox chk_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelTenLop;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_DiaCHi;
        private MetroFramework.Controls.MetroTextBox txt_HoTen;
        private MetroFramework.Controls.MetroTextBox txt_Msv;
        private MetroFramework.Controls.MetroTextBox txt_TenLop;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btn_xoa;
        private MetroFramework.Controls.MetroButton btn_Update;
    }
}