using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan01
{
    public partial class Frm_BTM1 : Form
    {
        public Frm_BTM1()
        {
            InitializeComponent();
        }

        private void Frm_BTM1_Load(object sender, EventArgs e)
        {
     
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtYear.Text.Length > 0 &&!txtYear.Text.All(Char.IsDigit))
            {
                this.errorProvider1.SetError(txtYear, "Vui Lòng Nhập Tuổi chứ không nhập chữ");
            }
            else
                this.errorProvider1.Clear();
        }

        private void ShowBt_Click(object sender, EventArgs e)
        {
            string kq="My Name is: "+txtName.Text+"\n"+"Age: ";
            try
            {
                int tuoi = DateTime.Now.Year - int.Parse(txtYear.Text);
                kq += tuoi.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Bạn Nấu Ăn Đi");
            }
            
           
            MessageBox.Show(kq);
        }

        private void CLearbt_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            txtName.Focus();
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "Vui Long Nhap Tuoi");
            }
            else
                errorProvider1.Clear();
        }

        private void Frm_BTM1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

    }
}
