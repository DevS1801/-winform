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
    public partial class Frm1_BTTL1 : Form
    {
        public Frm1_BTTL1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string kq = "Kết Quả là: \n";
            float a = float.Parse(texta.Text);
            float b = float.Parse(textB.Text);
            TinhToan dt = new TinhToan(a, b);
            if (radioAdd.Checked)
            {
                textKQ.Text = dt.cong().ToString();
            }    
            else if (radioTru.Checked)
                textKQ.Text = dt.tru().ToString();
            else if (radioNhan.Checked)
                textKQ.Text = dt.nhan().ToString();
            else
                if (b != 0)
                textKQ.Text = dt.chia().ToString();
            else
                    MessageBox.Show("Phép chia bị lỗi á, xem lại giúp tớ nhé!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Question);

        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Frm1_BTTL1_Load(object sender, EventArgs e)
        {

        }
    }
}
