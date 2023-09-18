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
    public partial class Frm_BTVN2 : Form
    {
        public Frm_BTVN2()
        {
            InitializeComponent();
        }


        private  int tong = 0;
        private int tongChan = 0;
        private int tongLe = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(txtNhap.Text, out int numA))
            {
                TxtDaNhap.Text += numA + " ";

                tong += numA;
                TxtTong.Text = tong.ToString();

                if (numA % 2 == 0)
                {
                    tongChan += numA;
                    TxtChan.Text = tongChan.ToString();
                }
                else
                {
                    tongLe += numA;
                    TxtLe.Text = tongLe.ToString();
                }

                txtNhap.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void BtnTT_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            TxtDaNhap.Clear();
            TxtTong.Clear();
            TxtChan.Clear();
            TxtLe.Clear();
            txtNhap.Focus();
        }

        private void Frm_BTVN2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn Có Muốn Thoát?", "THông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
