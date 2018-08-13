using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader_Express.OBJECT
{
    class InventoryInfor
    {
        public string tagID { set; get; }
        public string text { set; get; }
        public int rssi { set; get; }
        public DateTime time_stamp { set; get; }
        public int antenna_number { set; get; }
    }
}
