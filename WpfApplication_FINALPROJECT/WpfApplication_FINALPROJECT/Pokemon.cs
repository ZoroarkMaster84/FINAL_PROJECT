using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_FINALPROJECT
{
    public class Pokemon
    {
        string type;
        int hp;
        int attack;
        int defense;
        int sp_atk;
        int sp_def;
        int speed;

        public Pokemon(string type, int hp, int attack, int defense, int sp_atk, int sp_def, int speed)
        {
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
