using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace _31_731_LeBuiThienDuc_Tuan01
{
    public partial class Frm_BTTL2 : Form
    {
        public Frm_BTTL2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNamee_Leave(object sender, EventArgs e)
        {
            if (txtNamee.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtNamee, "Vui Lòng Nhập Tên Đăng Nhập");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@"))
            {
                this.errorProvider1.SetError(txtEmail, "Vui Lòng Nhập Đúng Email");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text.Length == 0&&txtpass.Text.Length<8)
            {
                this.errorProvider1.SetError(txtpass, "Vui Lòng Nhập Mật Khẩu Trên 8 Kí Tự");
            }
            else
                this.errorProvider1.Clear();
        }
        //public bool email(string email)
        //{
        //    try
        //    {
        //        MailAddress m = new MailAddress(email);
        //        return true;
        //    }
        //    catch(Exception ex)
        //    {
        //        return false;
        //    }
        //}
        private void txtrtpass_TextChanged(object sender, EventArgs e)
        {
            if (!txtrtpass.Text.Equals(txtpass.Text))
            {
                this.errorProvider1.SetError(txtrtpass, "Mật Khẩu Không Khớp");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txtNamee_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            try
            {
                string kq = "Tên Đăng Nhập: " + txtNamee.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Pass: " + txtpass.Text;
                MessageBox.Show(kq);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn Xem Lại Thông tin đã nhập?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text.Length == 0 || txtpass.Text.Length < 8)
            {
                this.errorProvider1.SetError(txtpass, "Vui Lòng Nhập Mật Khẩu Trên 8 Kí Tự");
            }
            else
                this.errorProvider1.Clear();
        }

        private void Frm_BTTL2_Load(object sender, EventArgs e)
        {

        }

        private void Frm_BTTL2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
