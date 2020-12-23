using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class PC : Device
    {
        public OperatingSystem nameOfOS { get; set; }
        public string nameOfRam { get; set; }
        public int sizeOfDisk { get; set; }
        public string nameOfCPU { get; set; }
        public PC() { }
        public PC(OperatingSystem nameofos, string nameofram, int sizeofdisk, string nameofcpu,
            Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty)
        {
            this.nameOfOS = nameofos;
            this.nameOfRam = nameofram;
            this.sizeOfDisk = sizeofdisk;
            this.nameOfCPU = nameofcpu;
        }
        public PC(Device device) : base(device)
        { }
    }
}
