using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTinHoc
{
    public class Manager:Human
    {
        protected Database managerDB;
        public Manager(string name, string age, string id) : base(name, age, id) 
        {
            managerDB = new Database();
        }
        public Manager(Human human) : base(human) 
        {
            managerDB = new Database();
        }
        public Manager()
        {
            managerDB = new Database();
        }
        public object RemoveDevice(Device device)
        {
            managerDB.queryEvent += ManagerDB_queryEvent;
            return managerDB.Query(device);
        }
        public object AddDevice(Device device)
        {
            managerDB.queryEvent += ManagerDB_queryEvent2;
            return managerDB.Query(device);
        }
        private object ManagerDB_queryEvent(params object[] pas)
        {
            return "Remove device";
        }
        private object ManagerDB_queryEvent2(params object[] pas)
        {
            return "Add device";
        }

        public object openLabRoom(params object[] pas)
        {
            return "\nOpen";
        }
        public object closeLabRoom(params object[] pas)
        {
            return "\nClose";
        }
        public object inspectionDV(params object[]thamso)
        {
            return "kiem tra thiết bị sau moi buoi";
        }
        public bool kiemTra(params object[] thamso)
        {
            Random rand = new Random();
           return rand.NextDouble() > 0.5;

        }

        public object processingUS(params object[] thamso)
        {
          
            return "hinh thuc xu li";
        }
        public object checkProcessing(params object[] thamso)
        {
            
            return "kiem tra nop phat";
        }
        public object congViec(params object[]thamso)
        {
            object ketqua = this.processingUS();
            bool kq = this.kiemTra();
            if (kq == true)
                return (string)"khong co thiet bi hu";
            object kq1 = this.processingUS();
            object kq2 = this.checkProcessing(kq1);
            return kq2;
        }
    }
}
