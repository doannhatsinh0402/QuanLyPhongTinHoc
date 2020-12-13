using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Database
    {
        public DataType typeOfDateBase { get; set; }
        public List<Device> listDevices { get; set; }
        public List<Human> listHuman { get; set; }
    }
}