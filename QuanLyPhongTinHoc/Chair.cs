using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Chair : Device
    {
        public Chair() { }
        public Chair(Type typechair,Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty)
            :base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty)
        {
            this.typeChair = typechair;
        }
        public Chair(Device device) : base(device) { }
        public Type typeChair { get; set; }
    }
}