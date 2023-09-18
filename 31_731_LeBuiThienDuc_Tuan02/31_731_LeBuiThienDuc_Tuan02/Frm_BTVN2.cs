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
    public partial class Frm_BTVN2 : Form
    {
        List<int> lst_dayso;
        public Frm_BTVN2()
        {
            InitializeComponent();
            lst_dayso = new List<int>();
        }


        
        private void btnNhap_Click(object sender, EventArgs e)
        {
            lst_dayso.Add(int.Parse(txtNhap.Text));
            TxtDaNhap.Text += txtNhap.Text + " ";
            txtNhap.Clear();
            txtNhap.Focus();
            
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            int tong=lst_dayso.Sum();
            TxtTong.Text = tong.ToString();
            int tongchan = lst_dayso.Where(x => x % 2 == 0).Sum();
            TxtChan.Text = tongchan.ToString();
            int tongle = lst_dayso.Where(y => y % 2 != 0).Sum();
            TxtLe.Text = tongle.ToString();
        }
    }
}
