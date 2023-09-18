namespace _31_731_LeBuiThienDuc_Tuan05
{
    partial class frmBTTL1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMsv = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkChinese = new System.Windows.Forms.CheckBox();
            this.cb_Nation = new System.Windows.Forms.ComboBox();
            this.lst1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenDer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "GenDer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "MaSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nation";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtMsv
            // 
            this.txtMsv.Location = new System.Drawing.Point(110, 75);
            this.txtMsv.Name = "txtMsv";
            this.txtMsv.Size = new System.Drawing.Size(253, 20);
            this.txtMsv.TabIndex = 1;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(110, 110);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(48, 17);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Male";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(228, 110);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(59, 17);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Female";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(110, 144);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(60, 17);
            this.chkAnh.TabIndex = 3;
            this.chkAnh.Text = "English";
            this.chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(216, 141);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(59, 17);
            this.chkPhap.TabIndex = 3;
            this.chkPhap.Text = "France";
            this.chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkChinese
            // 
            this.chkChinese.AutoSize = true;
            this.chkChinese.Location = new System.Drawing.Point(319, 141);
            this.chkChinese.Name = "chkChinese";
            this.chkChinese.Size = new System.Drawing.Size(64, 17);
            this.chkChinese.TabIndex = 3;
            this.chkChinese.Text = "Chinese";
            this.chkChinese.UseVisualStyleBackColor = true;
            // 
            // cb_Nation
            // 
            this.cb_Nation.FormattingEnabled = true;
            this.cb_Nation.Location = new System.Drawing.Point(110, 167);
            this.cb_Nation.Name = "cb_Nation";
            this.cb_Nation.Size = new System.Drawing.Size(121, 21);
            this.cb_Nation.TabIndex = 4;
            // 
            // lst1
            // 
            this.lst1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.MSV,
            this.GenDer,
            this.Language,
            this.nation});
            this.lst1.Location = new System.Drawing.Point(12, 222);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(436, 129);
            this.lst1.TabIndex = 5;
            this.lst1.UseCompatibleStateImageBehavior = false;
            this.lst1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 110;
            // 
            // MSV
            // 
            this.MSV.Text = "Ma SV";
            this.MSV.Width = 87;
            // 
            // GenDer
            // 
            this.GenDer.Text = "GenDer";
            this.GenDer.Width = 88;
            // 
            // Language
            // 
            this.Language.Text = "Language";
            this.Language.Width = 73;
            // 
            // nation
            // 
            this.nation.Text = "Nation";
            this.nation.Width = 104;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(200, 372);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(319, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmBTTL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 424);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.cb_Nation);
            this.Controls.Add(this.chkChinese);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtMsv);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "frmBTTL1";
            this.Load += new System.EventHandler(this.frmBTTL1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMsv;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkChinese;
        private System.Windows.Forms.ComboBox cb_Nation;
        private System.Windows.Forms.ListView lst1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader MSV;
        private System.Windows.Forms.ColumnHeader GenDer;
        private System.Windows.Forms.ColumnHeader Language;
        private System.Windows.Forms.ColumnHeader nation;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}