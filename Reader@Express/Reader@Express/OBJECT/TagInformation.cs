using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader_Express.OBJECT
{
    class TagInformation
    {
        public string TIDMem { set; get; }
        public string EPCMem { set; get; }
        public string userMem { set; get; }
        public string reservedMem { set; get; }
        public DateTime timeStamp { set; get; }
        public float objectData { set; get; }
    }
}
