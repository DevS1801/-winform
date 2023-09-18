using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_731_LeBuiThienDuc_Tuan02
{
    class Phuongtrinh
    {

        private double _heSoA;
        private double _heSoB;
        private double _heSoC;
        public Phuongtrinh(double a,double b)
        {
            _heSoA = a;
            _heSoB = b;
        }
        public Phuongtrinh(double a, double b, double c)
        {
            _heSoA = a;
            _heSoB = b;
            _heSoC = c;
        }

        public double GiaiPhuongTrinhBacNhat()
        {
            if (_heSoA == 0)
            {
                throw new ArgumentException("Hệ số 'a' phải khác 0 trong phương trình bậc nhất.");
            }

            double x = -_heSoB / _heSoA;
            return x;
        }

        public double[] GiaiPhuongTrinhBacHai()
        {
            double delta = _heSoB * _heSoB - 4 * _heSoA * _heSoC;

            if (delta < 0)
            {
                throw new ArgumentException("Phương trình bậc hai không có nghiệm thực.");
            }

            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-_heSoB + sqrtDelta) / (2 * _heSoA);
            double x2 = (-_heSoB - sqrtDelta) / (2 * _heSoA);

            return new double[] { x1, x2 };
        }
    }
}
