﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Cabinet : Device
    {
        public string posOfCabinet { get; set; }
        public List<Device> listDevices { get; set; }
        protected Database cabinetDB;
        public Cabinet()
        {
            Database cabinetDB = new Database(); 
        }
    }
}