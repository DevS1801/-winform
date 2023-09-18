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
    public partial class Frm_VN4 : Form
    {
        private MangSoNguyen array;
        public Frm_VN4()
        {
            InitializeComponent();
            array = new MangSoNguyen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_VN4_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int[] inputArray = txtNhap.Text.Trim().Split(' ').Select(int.Parse).ToArray();//tách ra các chuỗi con sau đó chuyeennr đổi thành số vào mảng
                array.NhapMang(inputArray);

                string currentOutput = txtoutput.Text.Trim();
                string newOutput = string.Join(" ", inputArray); 
                if (!string.IsNullOrEmpty(currentOutput))
                {
                    newOutput = currentOutput + " " + newOutput;
                }

                txtoutput.Text = newOutput;
                txtNhap.Text = ""; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void txtoutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            if(rdTang.Checked)
            {
                array.SapXep(true);
            }
            else
                if(rdGIam.Checked)
            {
                array.SapXep(false);
            }
            txtoutput.Text = string.Join(" ", array.XuatMang());
            search();
           
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtoutput.Clear();
            txtTimDuoc.Clear();
            txtGTCanTim.Clear();
            txtvitritim.Clear();
            txtGTxoa.Clear();
            txtVTXoa.Clear();
            txtGTTHem.Clear();
            TxtViTriThem.Clear();
            txttongManh.Clear();
            txtChan.Clear();
            txtLe.Clear();
            txtMaxx.Clear();
            TxtMin.Clear();
            txtGTTHay.Clear();
            txtVTThay.Clear();
            TxtKqThay.Clear();
        }
        private void search()
        {
            
            
                if (rdGTtim.Checked)
                {
                    int giatri = int.Parse(txtGTCanTim.Text);
                    txtTimDuoc.Text = array.TimGiaTri_ViTri(giatri).ToString();
                if(int.Parse(txtTimDuoc.Text)==-1)
                {
                    MessageBox.Show("Không Tìm Thấy Giá trị này");
                }
                txtGTCanTim.Clear();
                }
                else
                    if (rdVTtim.Checked)
                {
                    int vitri = int.Parse(txtvitritim.Text);
                    txtTimDuoc.Text = array.TimViTri_GiaTri(vitri).ToString();
                      if (int.Parse(txtTimDuoc.Text) == -1)
                     {
                    MessageBox.Show("Không Tìm Thấy Giá trị này");
                    }
                      txtvitritim.Clear();
            }
            
            
        }
    }
}
