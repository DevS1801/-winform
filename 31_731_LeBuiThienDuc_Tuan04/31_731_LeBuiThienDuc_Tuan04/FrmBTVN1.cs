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
    public partial class FrmBTVN1 : Form
    {
        public FrmBTVN1()
        {
            InitializeComponent();
            tr_Lop.AfterSelect += tr_Lop_AfterSelect;
        }

        private void chk_Add_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Add.Checked)
            {
                labelTenLop.Enabled = true;
                txt_TenLop.Enabled=true;
                btnThem.Enabled = true;
            }
        }

        private void FrmBTVN1_Load(object sender, EventArgs e)
        {
            string[] lop = { "12DHTH01", "12DHTH02", "12DHTH03", "12DHTH04" };
            foreach(string s in lop)
            {
                tr_Lop.Nodes[0].Nodes.Add(s);
                Cb_Lop.Items.Add(s);
            }
            Cb_Lop.SelectedIndex= 0;
           
        }
        public bool kiemtra(string s)
        {
            foreach(TreeNode node in tr_Lop.Nodes)
            {
                if(node.Text.Equals(s,StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TenLop.Text))
            {
                if (!kiemtra(txt_TenLop.Text))
                {
                    tr_Lop.Nodes[0].Nodes.Add(txt_TenLop.Text);
                    Cb_Lop.Items.Add(txt_TenLop.Text);
                }
                else
                    MessageBox.Show("Lớp Học Đã Tồn Tại");
                txt_TenLop.Clear();
                txt_TenLop.Focus();
            }
            else
                MessageBox.Show("Vui Lòng Nhập tên lớp");
            txt_TenLop.Focus();
        }
        public bool kiemtramssv(TreeNodeCollection nodes, string s)
        {
            foreach (TreeNode node in nodes)
            {
                // Tách MSSV ra từ nội dung node
                string[] nodeParts = node.Text.Split(',');
                if (nodeParts.Length >= 1)
                {
                    string mssv = nodeParts[0].Trim();

                    // So sánh MSSV (chỉ phần số) với MSSV bạn nhập
                    if (mssv == s)
                    {
                        return true;
                    }
                }

                if (kiemtramssv(node.Nodes, s)) // Kiểm tra trong các node con của node hiện tại
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Msv.Text) && !string.IsNullOrEmpty(txt_HoTen.Text) && !string.IsNullOrEmpty(txt_DiaCHi.Text))
            {
                string mssv = txt_Msv.Text;
                string lop = Cb_Lop.Text;

                // Kiểm tra xem MSSV đã tồn tại trong cây không
                if (!kiemtramssv(tr_Lop.Nodes, mssv))
                {
                    TreeNode parentNode = null;

                    // Tìm node của lớp trong cây nếu tồn tại
                    foreach (TreeNode node in tr_Lop.Nodes[0].Nodes)
                    {
                        // Tách tên lớp ra khỏi nội dung node
                        string nodeName = node.Text.Split(',')[0].Trim();

                        if (nodeName == lop)
                        {
                            parentNode = node;
                            break;
                        }
                    }

                    if (parentNode != null)
                    {
                        // Thêm thông tin sinh viên vào lớp đã tồn tại
                        TreeNode studentNode = new TreeNode(mssv + "," + txt_HoTen.Text);
                        TreeNode addressNode = new TreeNode(txt_DiaCHi.Text);
                        studentNode.Nodes.Add(addressNode);
                        parentNode.Nodes.Add(studentNode);
                        tr_Lop.ExpandAll();
                    }
                    else
                    {
                        MessageBox.Show("Lớp không tồn tại trong cây.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Số Sinh viên bị trùng.");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô.");
            }
            txt_HoTen.Clear();
            txt_Msv.Clear();
            txt_DiaCHi.Clear();
            txt_Msv.Focus();
        }

        private void tr_Lop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Kiểm tra nếu là node sinh viên (có thông tin MSSV, Tên và Địa chỉ)
            if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Nodes.Count == 1)
            {
                string[] studentInfo = selectedNode.Text.Split(',');

                // Hiển thị thông tin sinh viên lên các TextBox
                txt_Msv.Text = studentInfo[0];
                txt_HoTen.Text = studentInfo[1];

                // Lấy địa chỉ từ node con của node sinh viên
                txt_DiaCHi.Text = selectedNode.Nodes[0].Text;
            }
            else
            {
                // Nếu không phải là node sinh viên, xóa nội dung các TextBox
                txt_Msv.Clear();
                txt_HoTen.Clear();
                txt_DiaCHi.Clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (tr_Lop.SelectedNode != null)//đã được chọn
                {
                    TreeNode selectedNode = tr_Lop.SelectedNode;

                    // Kiểm tra xem nút đã chọn có nút con (sinh viên) không
                    bool hasStudents = selectedNode.Nodes.Count > 0;

                    if (!hasStudents)
                    {
                        // Nếu không có sinh viên, không cho phép xóa lớp
                        MessageBox.Show("Không có để xóa");
                        return;
                    }
                    tr_Lop.Nodes.Remove(tr_Lop.SelectedNode);
                }
            }
        }


    }
}
