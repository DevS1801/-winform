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
    public partial class Frm_VN1 : Form
    {
        public Frm_VN1()
        {
            InitializeComponent();
        }

        private void ChkRE_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkRE.Checked==true)
            {
                Name.Font = new Font(Name.Font, FontStyle.Regular);
            }    
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBold.Checked == true)
            {
                Name.Font = new Font(Name.Font, FontStyle.Bold);
            }
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkItalic.Checked == true)
            {
                Name.Font = new Font(Name.Font, FontStyle.Italic);
            }
        }

        private void chkIt_bold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIt_bold.Checked == true)
            {
                Name.Font = new Font(Name.Font,(FontStyle) (FontStyle.Bold|FontStyle.Italic));
            }
        }

        private void AutoColor_CheckedChanged(object sender, EventArgs e)
        {
            if(AutoColor.Checked==true)
            {
                Random random = new Random();
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color randomColor = Color.FromArgb(r, g, b);
                Name.ForeColor = randomColor;

            }
        }

        private void rdred_CheckedChanged(object sender, EventArgs e)
        {
            if(rdred.Checked==true)
            {
                Name.ForeColor = Color.Red;
            }    
        }

        private void rdgreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgreen.Checked == true)
            {
                Name.ForeColor = Color.Green;
            }
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked == true)
            {
                Name.ForeColor = Color.Blue;
            }
        }

        private void Frm_VN1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_VN1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
