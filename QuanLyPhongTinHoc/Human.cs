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
        public Human(){}
        public Human(string name, string age, string id)
        {
            this.fullName = name;
            this.valueOfAge = age;
            this.valueOfId = id;
        }
        public Human(Human human)
        {
            this.fullName = human.fullName;
            this.valueOfAge = human.valueOfAge;
            this.valueOfId = human.valueOfId;
        }
        public virtual object CheckIn(params object[] pas) //pas == parameters
        {
            return "\nCheck in";
        }
        public virtual object CheckOut(params object[] pas)
        {
            return "\nCheck out";
        }
    }
}