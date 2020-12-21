using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTinHoc
{
    public class User:Human
    {
        public string checkIn(params object[]thamso)
        {
            return "ngay su dung + ten thiet bi hu hong";
        }
        public string compensationDV(params object[]thamso)
        {
            
            return "den bu theo quy dinh";
        }
    }
}
