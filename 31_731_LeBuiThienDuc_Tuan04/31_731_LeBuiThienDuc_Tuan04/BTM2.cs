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
    public partial class BTM2 : Form
    {
        public BTM2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };
            foreach(var s in dt)
            {
                cb_DT.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "dan toc duoc chon la: ";
            if (cb_DT.SelectedIndex >= 0)
            {
                lb_Kq.Text = s + cb_DT.SelectedItem.ToString();
            }
            else
                lb_Kq.Text = "Chua CHon dan toc";
        }
    }
}
