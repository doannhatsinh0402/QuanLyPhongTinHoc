using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTinHoc
{
    public  class Device
    {
        public Status qualityStatus { get; set; }
        public DateTime dateOfInstall { get; set; }
        public string nameDevice { get; set; }
        public string nameOfProducer { get; set; }
        public string colorOfDevice { get; set; }
        public string idDevice { get; set; }
       public DateTime dateOfWarranty { set; get; } //thoi gian bao hanh
        
        public List<Device> deviceConnect { get; set; }
        public string price { get; set; }
        public Device()
        {
            this.deviceConnect = new List<Device>();
        }
        public string liquidityDV(params object[]thamso)
        {

            return "tien thanh li \n";
        }
        public string buyNewDV(params object[]thamso)
        {
            return "so tien mua\n";
        }
     
        public string repairDV(params object[]thamso)
        {
            string dateKT = "ngay kiem tra";
             eventDV?.Invoke(dateKT);
            return dateKT;
        }
        
        public string warrantyDV(params object[] thamso)
        {
            return " bao hanh \n";
        }
        public object report(params object[] thamso)
        {
            string warranty = this.warrantyDV();
            string repair = this.repairDV();
            string BuyNewDevice = this.buyNewDV(repair);
            string ThanhLi = this.liquidityDV(repair);
            string ketqua = warranty + repair + BuyNewDevice + ThanhLi;

            return "bao cao";
        }
        public delegate void delegateDV(string kq);
        public event delegateDV eventDV;
    }
}
