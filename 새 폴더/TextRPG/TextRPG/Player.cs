using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {
        //힘 스텟
        private int power;
        public int Power { get { return power; } set { power = value; } }

        //스피드 스텟
        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }

        //지능 스텟
        private int intel;
        public int Intel { get { return intel; } set { intel = value; } } 

        public int money;
    }
}
