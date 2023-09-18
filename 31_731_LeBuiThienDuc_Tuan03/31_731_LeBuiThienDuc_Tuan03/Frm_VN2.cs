using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan03
{
    public partial class Frm_VN2 : Form
    {
        public Frm_VN2()
        {
            InitializeComponent();
        }

        private void btnGiai_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateGiaiButtonState()
        {
            bool allFieldsFilled = false;

            if (rd1.Checked) // Phương trình bậc nhất
            {
                allFieldsFilled = !string.IsNullOrEmpty(txta.Text) && !string.IsNullOrEmpty(txtb.Text);
            }
            else if (rd2.Checked) // Phương trình bậc hai
            {
                allFieldsFilled = !string.IsNullOrEmpty(txta.Text) && !string.IsNullOrEmpty(txtb.Text) && !string.IsNullOrEmpty(txtc.Text);
            }

            btnGiai.Enabled = allFieldsFilled;

        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                if (!string.IsNullOrEmpty(txta.Text) && !string.IsNullOrEmpty(txtb.Text))
                {
                    double a = double.Parse(txta.Text);
                    double b = double.Parse(txtb.Text);

                    Phuongtrinh pt = new Phuongtrinh(a, b);
                    if (double.Parse(txta.Text) == 0)
                    {
                        MessageBox.Show("Hệ SỐ a phải khác 0");
                    }
                    else
                    {

                        RichTxtKq.Text = "Nghiệm của Phương Trình Là: " + pt.GiaiPhuongTrinhBacNhat().ToString();
                    }
                }
                else
                    MessageBox.Show("Hãy nhập đầy đủ thông tin cho các ô!!");
            }
            else if (rd2.Checked)
            {

                //phương trình bậc 2
                if (!string.IsNullOrEmpty(txta.Text) && !string.IsNullOrEmpty(txtb.Text) && !string.IsNullOrEmpty(txtc.Text))
                {
                    double a = double.Parse(txta.Text);
                    double b = double.Parse(txtb.Text);
                    double c = double.Parse(txtc.Text);
                    Phuongtrinh pt = new Phuongtrinh(a, b, c);
                    try
                    {
                        double[] roots = pt.GiaiPhuongTrinhBacHai();
                        string result = "Nghiệm phương trình bậc hai:\n";

                        if (roots.Length == 2)
                        {
                            result += "x1 = " + roots[0] + "\n";
                            result += "x2 = " + roots[1];
                        }
                        else if (roots.Length == 1)
                        {
                            result += "x1 = x2 = " + roots[0];
                        }

                        RichTxtKq.Text = result;
                    }
                    catch (ArgumentException ex)
                    {
                        RichTxtKq.Text = "Lỗi: " + ex.Message;
                    }
                }
            }
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = false;
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txta.Focus();
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {

            txtc.Enabled = true;
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txta.Focus();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            UpdateGiaiButtonState();
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            UpdateGiaiButtonState();
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {
            UpdateGiaiButtonState();
        }

        private void Frm_VN2_Load(object sender, EventArgs e)
        {
            rd1.Focus();
            rd1.TabIndex = 0;
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            Close();
            
        }
    }
}
