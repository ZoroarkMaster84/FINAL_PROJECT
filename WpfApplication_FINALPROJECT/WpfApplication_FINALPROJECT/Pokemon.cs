using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_FINALPROJECT
{
    public class Pokemon
    {
        public string Name;
        public string type;
        public string hp;
        public string attack;
        public string defense;
        public string sp_atk;
        public string sp_def;
        public string speed;

        public Pokemon(string Name, string type, string hp, string attack, string defense, string sp_atk, string sp_def, string speed)
        {
            this.Name = Name;
            this.type = type;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.sp_atk = sp_atk;
            this.sp_def = sp_def;
            this.speed = speed;
        }
    }
}
