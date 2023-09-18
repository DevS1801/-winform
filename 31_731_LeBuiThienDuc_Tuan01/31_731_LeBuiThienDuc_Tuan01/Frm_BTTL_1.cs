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
    public partial class Frm_BTTL_1 : Form
    {
        public Frm_BTTL_1()
        {
            InitializeComponent();
        }

        private void NumA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(NumA.Text);
            double b = double.Parse(NumB.Text);
            double kq = a + b;
            txtkq.Text = kq.ToString();

        }

        private void btntru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(NumA.Text);
            double b = double.Parse(NumB.Text);
            double kq = a - b;
            txtkq.Text = kq.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(NumA.Text);
            double b = double.Parse(NumB.Text);
            double kq = a * b;
            txtkq.Text = kq.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(NumA.Text);
            double b = double.Parse(NumB.Text);
            if (b == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Số khác 0");
            }
            else
            {
                double kq = a / b;
                txtkq.Text = kq.ToString();
            }

        }

        private void Frm_BTTL_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void NumA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_BTTL_1_Load(object sender, EventArgs e)
        {

        }
    }
}
