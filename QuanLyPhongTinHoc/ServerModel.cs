using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class ServerModel : Device
    {
        public DateTime previousMaintenanceDate { get; set; }
        public ServerModel() { }
        public ServerModel(DateTime predate, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty,string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.previousMaintenanceDate = predate;
        }
        public ServerModel(Device device) : base(device)
        { }
    }
}