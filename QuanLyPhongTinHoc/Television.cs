﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Television : Device
    {
        public float valueOfInch { get; set; }
        public OperatingSystem nameOfOS { get; set; }
        public Television() { }
        public Television(float valueofinch,OperatingSystem nameofos, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty)
        {
            this.valueOfInch = valueofinch;
            this.nameOfOS = nameofos;
        }
        public Television(Device device) : base(device)
        { }
    }
}