using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTinHoc
{
    public class User:Human
    {
        public User() { }
        public User(string name,string age, string id) : base(name, age, id) { }
        public User(Human human) : base(human) { }
        public object checkIn(params object[]thamso)
        {
            return "ngay su dung + ten thiet bi hu hong";
        }
        public object compensationDV(params object[]thamso)
        {
            
            return "den bu theo quy dinh";
        }
    }
}
