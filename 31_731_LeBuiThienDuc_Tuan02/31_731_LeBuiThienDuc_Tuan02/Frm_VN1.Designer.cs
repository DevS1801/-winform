
namespace _31_731_LeBuiThienDuc_Tuan02
{
    partial class Frm_VN1
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
            this.Name = new System.Windows.Forms.Label();
            this.ChkRE = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.chkIt_bold = new System.Windows.Forms.CheckBox();
            this.AutoColor = new System.Windows.Forms.RadioButton();
            this.rdred = new System.Windows.Forms.RadioButton();
            this.rdgreen = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(80, 32);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(489, 32);
            this.Name.TabIndex = 0;
            this.Name.Text = "Trường Đại Học Công Thương HuIT";
            // 
            // ChkRE
            // 
            this.ChkRE.AutoSize = true;
            this.ChkRE.Location = new System.Drawing.Point(46, 21);
            this.ChkRE.Name = "ChkRE";
            this.ChkRE.Size = new System.Drawing.Size(83, 21);
            this.ChkRE.TabIndex = 1;
            this.ChkRE.Text = "ReGular";
            this.ChkRE.UseVisualStyleBackColor = true;
            this.ChkRE.CheckedChanged += new System.EventHandler(this.ChkRE_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Location = new System.Drawing.Point(46, 59);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(58, 21);
            this.ChkBold.TabIndex = 1;
            this.ChkBold.Text = "Bold";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Location = new System.Drawing.Point(46, 100);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(58, 21);
            this.ChkItalic.TabIndex = 1;
            this.ChkItalic.Text = "Italic";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // chkIt_bold
            // 
            this.chkIt_bold.AutoSize = true;
            this.chkIt_bold.Location = new System.Drawing.Point(46, 145);
            this.chkIt_bold.Name = "chkIt_bold";
            this.chkIt_bold.Size = new System.Drawing.Size(118, 21);
            this.chkIt_bold.TabIndex = 1;
            this.chkIt_bold.Text = "Bold and Italic";
            this.chkIt_bold.UseVisualStyleBackColor = true;
            this.chkIt_bold.CheckedChanged += new System.EventHandler(this.chkIt_bold_CheckedChanged);
            // 
            // AutoColor
            // 
            this.AutoColor.AutoSize = true;
            this.AutoColor.Location = new System.Drawing.Point(41, 23);
            this.AutoColor.Name = "AutoColor";
            this.AutoColor.Size = new System.Drawing.Size(93, 21);
            this.AutoColor.TabIndex = 2;
            this.AutoColor.TabStop = true;
            this.AutoColor.Text = "Auto color";
            this.AutoColor.UseVisualStyleBackColor = true;
            this.AutoColor.CheckedChanged += new System.EventHandler(this.AutoColor_CheckedChanged);
            // 
            // rdred
            // 
            this.rdred.AutoSize = true;
            this.rdred.Location = new System.Drawing.Point(41, 60);
            this.rdred.Name = "rdred";
            this.rdred.Size = new System.Drawing.Size(55, 21);
            this.rdred.TabIndex = 2;
            this.rdred.TabStop = true;
            this.rdred.Text = "Red";
            this.rdred.UseVisualStyleBackColor = true;
            this.rdred.CheckedChanged += new System.EventHandler(this.rdred_CheckedChanged);
            // 
            // rdgreen
            // 
            this.rdgreen.AutoSize = true;
            this.rdgreen.Location = new System.Drawing.Point(41, 102);
            this.rdgreen.Name = "rdgreen";
            this.rdgreen.Size = new System.Drawing.Size(69, 21);
            this.rdgreen.TabIndex = 2;
            this.rdgreen.TabStop = true;
            this.rdgreen.Text = "Green";
            this.rdgreen.UseVisualStyleBackColor = true;
            this.rdgreen.CheckedChanged += new System.EventHandler(this.rdgreen_CheckedChanged);
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(41, 146);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(57, 21);
            this.rdBlue.TabIndex = 2;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkIt_bold);
            this.panel1.Controls.Add(this.ChkItalic);
            this.panel1.Controls.Add(this.ChkBold);
            this.panel1.Controls.Add(this.ChkRE);
            this.panel1.Location = new System.Drawing.Point(40, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 205);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBlue);
            this.panel2.Controls.Add(this.rdgreen);
            this.panel2.Controls.Add(this.rdred);
            this.panel2.Controls.Add(this.AutoColor);
            this.panel2.Location = new System.Drawing.Point(360, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 206);
            this.panel2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Frm_VN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Name);
          
            this.Text = "Frm_VN1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_VN1_FormClosing);
            this.Load += new System.EventHandler(this.Frm_VN1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.CheckBox ChkRE;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox chkIt_bold;
        private System.Windows.Forms.RadioButton AutoColor;
        private System.Windows.Forms.RadioButton rdred;
        private System.Windows.Forms.RadioButton rdgreen;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
    }
}