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
    public partial class BTNC : Form
    {
        List<string> HO = new List<string>() { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        List<string> TENLOT = new List<string>(){"Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị",

"Kim", "Thái", "Hồng"};
        List<string> TEN = new List<string>(){"Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm",

"Phụng", "Thắm"};
        public BTNC()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void btnNhap_Click(object sender, EventArgs e)
        {
           
            string randomHo = HO[random.Next(HO.Count)];
            string randomTenLot = TENLOT[random.Next(TENLOT.Count)];
            string randomTen = TEN[random.Next(TEN.Count)];

          
            string hoTen = randomHo + " " + randomTenLot + " " + randomTen;

            
            lst_Xuat.Items.Add(hoTen);
        }

        private void btnXoaPTChon_Click(object sender, EventArgs e)
        {
            lst_Xuat.Items.Remove(lst_Xuat.SelectedItem.ToString());
        }

        private void BtnSon_Click(object sender, EventArgs e)
        {
            string tenCanXoa = "Sơn"; // Tên cần xóa

            for (int i = lst_Xuat.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = lst_Xuat.Items[i].ToString();

                // Kiểm tra xem tên trong ListBox có chứa "Sơn" không
                if (hoTen.Contains(tenCanXoa))
                {
                    lst_Xuat.Items.RemoveAt(i); // Xóa mục nếu chứa tên "Sơn"
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            string HocanXoa = "Lê"; // Tên cần xóa

            for (int i=0; i <lst_Xuat.Items.Count; i++)
            {
                string hoTen = lst_Xuat.Items[i].ToString();

        
                if (hoTen.Contains(HocanXoa))
                {
                    lst_Xuat.Items.RemoveAt(i);
                }
            }
        }

        private void BTnXoaALL_Click(object sender, EventArgs e)
        {
            lst_Xuat.Items.Clear();
        }

    }
}
