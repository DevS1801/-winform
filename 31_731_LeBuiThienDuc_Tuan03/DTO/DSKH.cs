using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_731_LeBuiThienDuc_Tuan03
{
   public class DSKH
    {
        List<KhachHang> listkh;

        internal List<KhachHang> Listkh
        {
            get { return listkh; }
            set { listkh = value; }
        }
        public DSKH()
        {
            listkh = new List<KhachHang>();
        }

       public double ThanhTien()
        {
            double thanhtien = 0;
           foreach(KhachHang item in listkh)
           {
               thanhtien += item.thanhtoan();
           }
           return thanhtien;
        }

    }
}
