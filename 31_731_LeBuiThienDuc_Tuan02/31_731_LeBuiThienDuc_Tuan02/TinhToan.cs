using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_731_LeBuiThienDuc_Tuan02
{
    class TinhToan
    {
        float a, b;
        public float A
        {
            get { return a; }
            set
            {
                a = value;
            }
        }
        public float B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }
        public TinhToan()
        {
            a=b=0;
        }
        public  TinhToan(float _a, float _b)
        {
            a = _a;
            b = _b;
        }
       public float cong()
        {
            return A + B;
        }
        public float tru()
       {
           return A - B;
       }
        public float nhan()
        {
            return A * B;
        }
        public float chia()
        {
            return A / B;

        }
    }
}
