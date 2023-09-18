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
    public partial class Frm_VN3 : Form
    {
        public Frm_VN3()
        {
            InitializeComponent();
        }

        private void Frm_VN3_Load(object sender, EventArgs e)
        {
            txtName.Focus();
          
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Close();
        }

        private void btnTinhTIen_Click(object sender, EventArgs e)
        {
            
        }
       
        private void check()
        {
            if(!string.IsNullOrEmpty(txtName.Text)&&!string.IsNullOrEmpty(TxtSoKH.Text))
            {
                if (checkRadio() && Checkbox())
                    btnTinhTIen.Enabled = true;
            }    
        }
        private bool checkRadio()
        {
            RadioButton[] radioButtons = { rdcfsuada,rdCfsua, rdcfkem, rdcfden, rdcfda };

            foreach (RadioButton radioButton in radioButtons)
            {
                if (!radioButton.Checked)
                {
                    return false;
                }
            }
            return true;
        }

        private bool Checkbox()
        {
            CheckBox[] checkBoxes = { ckmica, ckMiTomTrung, ckmitrung, ckMixaobo, CkMiCay }; 

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (!checkBox.Checked)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void rdcfden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckmitrung_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
