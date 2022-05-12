using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFOK_System
{
    public class recipt { 
    
        public int order_id { get; set; }
        public string item { get; set; }
        public int qty { get; set; }
        public double cost { get; set; }
        public string store { get; set; }
        public string payment { get; set; }

    }
}
