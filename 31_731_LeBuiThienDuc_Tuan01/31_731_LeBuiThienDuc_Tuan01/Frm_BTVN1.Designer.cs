﻿
namespace _31_731_LeBuiThienDuc_Tuan01
{
    partial class Frm_BTVN1
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
            this.Numa = new System.Windows.Forms.TextBox();
            this.NumB = new System.Windows.Forms.TextBox();
            this.txtUCLN = new System.Windows.Forms.TextBox();
            this.TxtBCNN = new System.Windows.Forms.TextBox();
            this.btnTH = new System.Windows.Forms.Button();
            this.BtnTT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Số a: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Số b: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ước Chung Lớn Nhất: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bội Chung Nhỏ Nhất: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Numa
            // 
            this.Numa.Location = new System.Drawing.Point(240, 111);
            this.Numa.Name = "Numa";
            this.Numa.Size = new System.Drawing.Size(174, 22);
            this.Numa.TabIndex = 1;
            this.Numa.TextChanged += new System.EventHandler(this.Numa_TextChanged);
            this.Numa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numa_KeyPress);
            // 
            // NumB
            // 
            this.NumB.Location = new System.Drawing.Point(240, 173);
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(174, 22);
            this.NumB.TabIndex = 1;
            this.NumB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumB_KeyPress);
            // 
            // txtUCLN
            // 
            this.txtUCLN.Enabled = false;
            this.txtUCLN.Location = new System.Drawing.Point(240, 235);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.Size = new System.Drawing.Size(87, 22);
            this.txtUCLN.TabIndex = 1;
            // 
            // TxtBCNN
            // 
            this.TxtBCNN.Enabled = false;
            this.TxtBCNN.Location = new System.Drawing.Point(240, 297);
            this.TxtBCNN.Name = "TxtBCNN";
            this.TxtBCNN.Size = new System.Drawing.Size(87, 22);
            this.TxtBCNN.TabIndex = 1;
            // 
            // btnTH
            // 
            this.btnTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTH.Location = new System.Drawing.Point(56, 361);
            this.btnTH.Name = "btnTH";
            this.btnTH.Size = new System.Drawing.Size(107, 45);
            this.btnTH.TabIndex = 2;
            this.btnTH.Text = "Thực Hiện";
            this.btnTH.UseVisualStyleBackColor = true;
            this.btnTH.Click += new System.EventHandler(this.btnTH_Click);
            // 
            // BtnTT
            // 
            this.BtnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTT.Location = new System.Drawing.Point(202, 361);
            this.BtnTT.Name = "BtnTT";
            this.BtnTT.Size = new System.Drawing.Size(107, 45);
            this.BtnTT.TabIndex = 2;
            this.BtnTT.Text = "Tiếp Tục";
            this.BtnTT.UseVisualStyleBackColor = true;
            this.BtnTT.Click += new System.EventHandler(this.BtnTT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(348, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 45);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_BTVN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.BtnTT);
            this.Controls.Add(this.btnTH);
            this.Controls.Add(this.TxtBCNN);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.Numa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BTVN1";
            this.Text = "Frm_BTVN1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BTVN1_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BTVN1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numa;
        private System.Windows.Forms.TextBox NumB;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.TextBox TxtBCNN;
        private System.Windows.Forms.Button btnTH;
        private System.Windows.Forms.Button BtnTT;
        private System.Windows.Forms.Button btnThoat;
    }
}