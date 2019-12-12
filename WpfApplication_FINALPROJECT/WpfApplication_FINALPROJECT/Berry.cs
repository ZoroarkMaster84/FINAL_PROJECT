using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_FINALPROJECT
{
    public class Berry : Item
    {
       public string status;
        
        public Berry(string status, string name)
        {
            this.status = status;
            this.name = name;
        }
    }
}
