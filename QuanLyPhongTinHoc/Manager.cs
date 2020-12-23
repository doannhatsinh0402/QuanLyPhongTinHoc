using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTinHoc
{
    public class Manager:Human
    {
        public string openLabRoom(params object[] pas)
        {
            return "\nOpen";
        }
        public string closeLabRoom(params object[] pas)
        {
            return "\nClose";
        }
        public string inspectionDV(params object[]thamso)
        {
            return "kiem tra thiết bị sau moi buoi";
        }
        public bool kiemTra(params object[] thamso)
        {
            Random rand = new Random();
           return rand.NextDouble() > 0.5;

        }

        public string processingUS(params object[] thamso)
        {
          
            return "hinh thuc xu li";
        }
        public string checkProcessing(params object[] thamso)
        {
            
            return "kiem tra nop phat";
        }
        public string congViec(params object[]thamso)
        {
            string ketqua = this.processingUS();
            bool kq = this.kiemTra();
            if (kq == true)
                return "khong co thiet bi hu";
            string kq1 = this.processingUS();
            string kq2 = this.checkProcessing(kq1);
            return kq2;
        }

    }
}
