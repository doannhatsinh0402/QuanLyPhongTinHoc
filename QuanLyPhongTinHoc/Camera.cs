using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongTinHoc
{
    public class Camera : Device
    {
        public Camera() { }
        public Camera(string posofcam,Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty)
        {
            this.posOfCamera = posofcam;
        }
        public Camera(Device device) : base(device)
        { }
        public string posOfCamera { get; set; }
    }
}