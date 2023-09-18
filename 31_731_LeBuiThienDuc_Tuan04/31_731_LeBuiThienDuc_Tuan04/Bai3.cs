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
    public partial class Bai3 : MetroFramework.Forms.MetroForm
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void treeVPHBAN_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }
        private bool kiemtra(string s)
        {
            foreach (TreeNode node in treeVPHBAN.Nodes)
            {
                if (node.Text.Equals(s, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void Bai3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach (string s in pb)
            {
                treeVPHBAN.Nodes.Add(s);
                cb_phongban.Items.Add(s);
            }
            cb_phongban.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemtra(txtNhap.Text))
            {
                treeVPHBAN.Nodes.Add(txtNhap.Text);
                cb_phongban.Items.Add(txtNhap.Text);

            }
            else
                MessageBox.Show("Đã tồn tại phòng ban trên");
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có Muốn xóa?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                if(treeVPHBAN.SelectedNode!=null)//đã được chọn
                {
                    cb_phongban.Items.Remove(treeVPHBAN.SelectedNode.Text);
                    treeVPHBAN.Nodes.Remove(treeVPHBAN.SelectedNode);
                }    
            }    
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //tìm index của node có nội dung là item được chọn trong combobox phòng ban
            int index = -1;
            foreach(TreeNode node in treeVPHBAN.Nodes)
            {
                if(node.Text==cb_phongban.Text)
                {
                    index = node.Index; break;
                }    
            }
            treeVPHBAN.Nodes[index].Nodes.Add(txtHoten.Text + "(" + txtMs.Text + ")" + "(" + txtDiachi.Text + ")");
            treeVPHBAN.ExpandAll();//mở rộng treeview
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (treeVPHBAN.SelectedNode != null)//đã được chọn
                {
                   
                    treeVPHBAN.Nodes.Remove(treeVPHBAN.SelectedNode);
                }
            }
        }
    }
}
