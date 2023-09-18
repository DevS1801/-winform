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
    public partial class frmBTTL2 : Form
    {
        public frmBTTL2()
        {
            InitializeComponent();
        }
     
        public bool kiemtra(string s)
        {
            
           foreach(ListViewItem item in lst1.Items)
           {
               string mssv = item.SubItems[0].Text;
               if (mssv.Equals(s,StringComparison.OrdinalIgnoreCase))
                   return false;
           }
            return true;//khong
        }
        int dem = 1;
        public void danhstt()
        {
            int i =1;
            foreach(ListViewItem item in lst1.Items)
            {
                if(i<=dem)
                {
                    item.SubItems[0].Text = i.ToString();
                    i++;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMsv.Text.Length>0  && txtName.Text.Length>0 )
            {
                if (kiemtra(txtMsv.Text))
                {
                    int stt = lst1.Items.Count+1;
                    lst1.Items.Add(stt.ToString()).SubItems.AddRange(new[] { txtMsv.Text, txtName.Text });
                }
                else
                    MessageBox.Show("Mssv Bi Trung");
                reset();
            }
            else MessageBox.Show("Vui Long Nhap Thong Tin Day Du");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lst1.SelectedItems)
            {
                item.Remove();
                dem = lst1.Items.Count;
            }
            danhstt();
            txtMsv.Enabled = true;
            reset();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
                if (lst1.FocusedItem != null)
                {
                    ListViewItem item = lst1.FocusedItem;
                    item.SubItems[1].Text = txtMsv.Text;
                    item.SubItems[2].Text = txtName.Text;

                }

            else
                MessageBox.Show("Trung MSV");
                txtMsv.Enabled = true;
            reset();
        }
        public void reset()
        {
            txtMsv.Clear();
            txtName.Clear();
            txtMsv.Focus();
        }
        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst1.SelectedItems.Count>0)
            {
                ListViewItem lst = lst1.SelectedItems[0];
                txtMsv.Text = lst.SubItems[1].Text;
                txtName.Text = lst.SubItems[2].Text;
                txtMsv.Enabled = false;
            }
        }

        private void lst1_Click(object sender, EventArgs e)
        {

        }
    }
}
