namespace _31_731_LeBuiThienDuc_Tuan01
{
    partial class Frm_BTTL_1
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
            this.NumA = new System.Windows.Forms.TextBox();
            this.NumB = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết Quả";
            // 
            // NumA
            // 
            this.NumA.Location = new System.Drawing.Point(96, 42);
            this.NumA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(153, 22);
            this.NumA.TabIndex = 1;
            this.NumA.TextChanged += new System.EventHandler(this.NumA_TextChanged);
            this.NumA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumA_KeyPress);
            // 
            // NumB
            // 
            this.NumB.Location = new System.Drawing.Point(313, 42);
            this.NumB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(153, 22);
            this.NumB.TabIndex = 1;
            this.NumB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumB_KeyPress);
            // 
            // txtkq
            // 
            this.txtkq.Enabled = false;
            this.txtkq.Location = new System.Drawing.Point(97, 81);
            this.txtkq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(369, 22);
            this.txtkq.TabIndex = 1;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(16, 133);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 28);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntru
            // 
            this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntru.Location = new System.Drawing.Point(147, 133);
            this.btntru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(100, 28);
            this.btntru.TabIndex = 2;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhan.Location = new System.Drawing.Point(277, 133);
            this.btnnhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(100, 28);
            this.btnnhan.TabIndex = 2;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchia.Location = new System.Drawing.Point(408, 133);
            this.btnchia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(100, 28);
            this.btnchia.TabIndex = 2;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // Frm_BTTL_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 196);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.NumA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_BTTL_1";
            this.Text = "Frm_BTTL_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BTTL_1_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BTTL_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumA;
        private System.Windows.Forms.TextBox NumB;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
    }
}