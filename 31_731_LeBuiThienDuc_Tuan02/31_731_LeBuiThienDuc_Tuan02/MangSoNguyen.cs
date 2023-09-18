using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_731_LeBuiThienDuc_Tuan02
{
    internal class MangSoNguyen
    {
        private List<int[]> mangNhap;

        public MangSoNguyen()
        {
            mangNhap = new List<int[]>();
        }

        public void NhapMang(int[] inputArray)
        {
            mangNhap.Add(inputArray);
        }

        public int[] XuatMang()
        {
            if (mangNhap.Count > 0)
            {
                return mangNhap[mangNhap.Count - 1];
            }
            return new int[0];
        }

        public void SapXep(bool tang)
        {
            int[] currentArray = XuatMang();

            if (tang)
            {
                Array.Sort(currentArray); // Sắp xếp tăng
            }
            else
            {
                Array.Sort(currentArray);
                Array.Reverse(currentArray); // Sắp xếp giảm
            }

            mangNhap[mangNhap.Count - 1] = currentArray; // Cập nhật lại mảng đã nhập
        }

        public int TimGiaTri_ViTri(int giaTri)
        {
            int[] currentArray = XuatMang();
            int viTri = Array.FindIndex(currentArray, item => item == giaTri);

            return viTri; // Trả về -1 nếu không tìm thấy giá trị
        }

        public int TimViTri_GiaTri(int viTri)
        {
            int[] currentArray = XuatMang();

            if (viTri >= 0 && viTri < currentArray.Length)
            {
                return currentArray[viTri];
            }
            return -1; // Nếu vị trí không hợp lệ
        }
        public void XoaGiaTri(int giaTri)
        {
            mangNhap[mangNhap.Count - 1] = mangNhap.Last().Where(val => val != giaTri).ToArray();
        }

        public void XoaViTri(int viTri)
        {
            int[] currentArray = XuatMang();

            if (viTri >= 0 && viTri < currentArray.Length)
            {
                mangNhap[mangNhap.Count - 1] = currentArray.Where((val, index) => index != viTri).ToArray();
            }
        }

        public void ThemViTri(int giaTri, int viTri)
        {
            int[] currentArray = XuatMang();
            List<int> tempList = new List<int>(currentArray);

            if (viTri >= 0 && viTri <= currentArray.Length)
            {
                tempList.Insert(viTri, giaTri);
                mangNhap.Add(tempList.ToArray());
            }
        }

        public int TinhTongMang()
        {
            int[] currentArray = XuatMang();
            return currentArray.Sum();
        }

        public int TinhTongChan()
        {
            int[] currentArray = XuatMang();
            return currentArray.Where(val => val % 2 == 0).Sum();
        }

        public int TinhTongLe()
        {
            int[] currentArray = XuatMang();
            return currentArray.Where(val => val % 2 != 0).Sum();
        }

        public int TimMax()
        {
            int[] currentArray = XuatMang();
            return currentArray.Max();
        }

        public int TimMin()
        {
            int[] currentArray = XuatMang();
            return currentArray.Min();
        }

        public void ThayThe(int giaTriCu, int giaTriMoi)
        {
            int[] currentArray = XuatMang();
            for (int i = 0; i < currentArray.Length; i++)
            {
                if (currentArray[i] == giaTriCu)
                {
                    currentArray[i] = giaTriMoi;
                }
            }
            mangNhap[mangNhap.Count - 1] = currentArray;
        }

        public void ThayTheViTri(int viTri, int giaTriMoi)
        {
            int[] currentArray = XuatMang();

            if (viTri >= 0 && viTri < currentArray.Length)
            {
                currentArray[viTri] = giaTriMoi;
                mangNhap[mangNhap.Count - 1] = currentArray;
            }
        }



    }
}

