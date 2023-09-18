using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan04
{
    public partial class BTTL1 : Form
    {
        List<int> ds;
        public BTTL1()
        {
            InitializeComponent();
            ds = new List<int>();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text != string.Empty && !cb_So.Items.Contains(txtNhap.Text))
            {
                cb_So.Items.Add(txtNhap.Text);
            }
            else
                MessageBox.Show("Moi ban nhap so khac");
            txtNhap.Clear();
            txtNhap.Focus();
        }
        List<int> DSuoc(int n)
        {
            List<int> ds=new List<int>();
            for(int i =1;i<n;i++)
            {
                if(n%i==0)
                    ds.Add(i);
            }
            return ds;
        }

        private void cb_So_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUoc.Items.Clear();
            List<int> ds2 = DSuoc(int.Parse(cb_So.SelectedItem.ToString()));
            foreach (var item in ds2)
            {
                lstUoc.Items.Add(item);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
         
            double tong = 0;
            foreach(var item in lstUoc.Items)
            {
                tong += int.Parse(item.ToString());
            }
            MessageBox.Show("Tổng: " + tong);
        }

        private void btnSoUocCHan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach(var item in lstUoc.Items)
            {
                if(int.Parse(item.ToString()) %2==0)
                {
                    dem++;
                }
            }
            MessageBox.Show("SL la: " + dem);
        }

        private void btnNguyenToLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (var item in lstUoc.Items)
            {
                if (IsPrime(int.Parse(item.ToString())))
                {
                    dem++;
                }
            }
            MessageBox.Show("SL la: " + dem);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "THông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(r==DialogResult.OK)
            {
                this.Close();
            }
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
        
    }
}
