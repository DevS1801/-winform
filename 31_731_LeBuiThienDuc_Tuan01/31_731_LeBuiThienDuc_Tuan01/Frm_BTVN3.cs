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
    public partial class Frm_BTVN3 : Form
    {
        public Frm_BTVN3()
        {
            InitializeComponent();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
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
        //method
        private string[] chuSo = {
            "", "Một", "Hai", "Ba", "Bốn", "Năm",
            "Sáu", "Bảy", "Tám", "Chín"
        };

        private string[] chuSoHangChuc = {
            "", "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi",
            "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi"
        };
        private string chuyendoiSo(int num)
        {
            if (num < 10)
                return chuSo[num];
            else
                if (num < 20)
            {
                return "Mười" + chuSo[num % 10];

            }
            else
                if (num < 100)
                return chuSoHangChuc[num / 10] + " " + chuSo[num % 10];
            else
                if (num < 1000)
                return chuSo[num / 100] + "Trăm" + chuyendoiSo(num % 100);
            return " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int number))
            {
                string txt = chuyendoiSo(number);
                TxtXuat.Text = txt;
            }
            else
                MessageBox.Show("Vui long nhap so tu 1 den 999");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            TxtXuat.Clear();
            txtNhap.Focus();
        }

        private void Frm_BTVN3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
