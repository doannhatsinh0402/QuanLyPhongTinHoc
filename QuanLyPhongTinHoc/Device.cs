using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{

    public abstract class Device
    {
        public Status qualityStatus { get; set; }
        public DateTime dateOfInstall { get; set; }
        public string nameDevice { get; set; }
        public string nameOfProducer { get; set; }
        public string colorOfDevice { get; set; }
        public string idDevice { get; set; }
        public List<Device> deviceConnect { get; set; }
        public string price { get; set; }
        public Device()
        {
            this.deviceConnect = new List<Device>();
        }
    }
}

