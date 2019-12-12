using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_FINALPROJECT
{
    public class HealingItem : Item
    {
        public string hp;

        public HealingItem(string hp, string name)
        {
            this.hp = hp;
            this.name = name;
        }
    }
}
