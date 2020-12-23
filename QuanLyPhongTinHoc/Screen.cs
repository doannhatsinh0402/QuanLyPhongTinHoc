using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Screen : Device
    {
        public float valueOfInch { get; set; }
        public Screen() { }
        public Screen(float valueofinch, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty)
        {
            this.valueOfInch = valueofinch;
        }
        public Screen(Device device) : base(device)
        { }
    }
}