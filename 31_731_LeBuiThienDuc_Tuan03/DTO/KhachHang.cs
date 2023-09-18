using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_731_LeBuiThienDuc_Tuan03
{
    public class KhachHang
    {
        private string _hoten;

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private int _SoNgayO;

        public int SoNgayO
        {
            get { return _SoNgayO; }
            set { _SoNgayO = value; }
        }



        private string loaiphong;

        public string Loaiphong
        {
            get { return loaiphong; }
            set { loaiphong = value; }
        }

        

        List<string> DichVu;

        public List<string> DichVu1
        {
            get { return DichVu; }
            set { DichVu = value; }
        }
        List<string> tienIch;

        public List<string> TienIch
        {
            get { return tienIch; }
            set { tienIch = value; }
        }
        public KhachHang()
        {
            Hoten = string.Empty;
            DiaChi = string.Empty;
            SoNgayO = 0;
            loaiphong = string.Empty;
            TienIch = new List<string>();
            DichVu1 = new List<string>();
        }
        public double thanhtoan()
        {
            double tong = 0;
            if (Loaiphong == "Phòng đơn")
                tong += 300000 * SoNgayO;
            else if (Loaiphong == "Phòng đôi")
                tong += 350000 * SoNgayO;
            else tong += 400000 * SoNgayO;
            tong += TienIch.Count * 10000;
            foreach(string itemdv in DichVu1)
            {
                if (itemdv == "Karaoke")
                    tong += 50000;
                else
                    tong += 15000 * SoNgayO;
            }
            
            return tong;
        }
        
    }
}
