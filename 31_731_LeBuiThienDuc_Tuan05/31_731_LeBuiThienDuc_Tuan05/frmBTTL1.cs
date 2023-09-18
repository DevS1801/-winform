using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan05
{
    public partial class frmBTTL1 : Form
    {
        public frmBTTL1()
        {
            InitializeComponent();
        }

        private void frmBTTL1_Load(object sender, EventArgs e)
        {
            string [] nation=new[]{"Kinh","Tay","E-De","Thai","Mong"};
            foreach(string item in nation)
            {
                cb_Nation.Items.Add(item);
            }
            cb_Nation.SelectedIndex=0;
        }
        public bool kiemtraMSSV(string s)
        {
            foreach(ListViewItem item in lst1.Items)
            {
                string mssv = item.SubItems[0].Text;
                if (mssv.Equals(s, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //CheckBox chk = (CheckBox)sender;
            //if (txtMsv.Text.Length > 0 && txtName.Text.Length > 0 && (rdNam.Checked ||rdNu.Checked)&& chk.Checked && cb_Nation.SelectedItem != null)
            //{
            //    if (kiemtraMSSV(txtMsv.Text))
            //        lst1.Items.Add(txtMsv.Text).SubItems.AddRange(new[] { txtName.Text, rd.Checked.ToString(), chk.Checked.ToString(), cb_Nation.SelectedItem.ToString() });
            //    else
            //        MessageBox.Show("Mssv bi trung");
            //}
            //else
            //    MessageBox.Show("Vui Long Nhap THong TIn Day Du");
        }

       

        

        

       
    }
}
