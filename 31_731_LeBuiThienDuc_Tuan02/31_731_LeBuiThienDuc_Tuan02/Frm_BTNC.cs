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
    public partial class Frm_BTNC : Form
    {
        List<Button> lst_btn;
        public Frm_BTNC()
        {
            InitializeComponent();
            lst_btn = new List<Button>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            foreach(Button b in lst_btn)
            {
                if(b.BackColor==Color.Blue)
                b.BackColor = Color.White;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    lst_btn.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    lst_btn.Remove(btn);
                }
        }
        int tong = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {

            txtThanhtien.Clear();
            foreach(Button b in lst_btn)
            {
                b.BackColor = Color.Yellow;
          
                if (int.Parse(b.Text) >= 1 && int.Parse(b.Text) <= 5)
                    tong += 1000;
                else
                    if (int.Parse(b.Text) >= 6 && int.Parse(b.Text) <= 10)
                        tong += 1500;
                    else
                  
                        tong += 2000;
            }
            lst_btn.Clear();
            txtThanhtien.Text = tong.ToString();
            tong = 0;
          
         
            
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_BTNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                
        }

        private void Frm_BTNC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;

        }

        private void Frm_BTNC_Load(object sender, EventArgs e)
        {

        }
    }
}
