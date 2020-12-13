using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Manager : Human
    {
        public string OpenLabRoom(params object[] pas)
        {
            return "\nOpen";
        }
        public string CloseLabRoom(params object[] pas)
        {
            return "\nClose";
        }
    }
}