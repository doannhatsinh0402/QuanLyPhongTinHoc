using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public abstract class Human
    {
        public string fullName { get; set; }
        public string valueOfAge { get; set; }
        public string valueOfId { get; set; }
        public virtual string CheckIn(params object[] pas) //pas == parameters
        {
            return "\nCheck in";
        }
        public virtual string CheckOut(params object[] pas)
        {
            return "\nCheck out";
        }
    }
}