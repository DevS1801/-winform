using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan02
{
    public partial class Frm_BTVN1 : Form
    {
        public Frm_BTVN1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BTVN1_Load(object sender, EventArgs e)
        {

        }

        private void Numa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void NumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            int a =int.Parse( Numa.Text);
            int b = int.Parse(NumB.Text);

            int ucln = UCLN(a, b);
            int bcnn = (a * b) / ucln;
            txtUCLN.Text = ucln.ToString();
            TxtBCNN.Text = bcnn.ToString();
        }
        //method
        private int UCLN(int a,int b)
        {
            //ucln
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;


                }
                else
                {
                    b = b - a;

                }
            }
            return a;

        }

        private void BtnTT_Click(object sender, EventArgs e)
        {
            Numa.Clear();
            NumB.Clear();
            txtUCLN.Clear();
            TxtBCNN.Clear();
            Numa.Focus();
        }

        private void Frm_BTVN1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có Muốn Thoát Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Numa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
