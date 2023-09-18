using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace _31_731_LeBuiThienDuc_Tuan03
{
    public partial class btvnTuan2 : Form
    {
        DSKH ds;
        
        public btvnTuan2()
        {
            InitializeComponent();
            ds = new DSKH();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btvnTuan2_Load(object sender, EventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Không được để trống");
            }
            else
                errorProvider1.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Hoten = txtName.Text;
            kh.DiaChi = txtAddress.Text;
            kh.SoNgayO = int.Parse(txtSoNgayO.Text);
            if (radioPhongDon.Checked)
            {
                kh.Loaiphong = radioPhongDon.Text;
            }
            else
                if (radioPhongDoi.Checked)
                    kh.Loaiphong = radioPhongDoi.Text;
                else
                    kh.Loaiphong = radioPhongBa.Text;

            //tiện ích, dịch vụ
            if (checkBoxTV.Checked)
                kh.TienIch.Add(checkBoxTV.Text);
            if (checkBoxInternet.Checked)
                kh.TienIch.Add(checkBoxInternet.Text);
            if(c)//về làm tiếp
        }
    }
}
