using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class BedendingScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("Bedend");
            Console.WriteLine();
            Console.WriteLine("당신은 도망친곳에서 조차 도망친 겁쟁이가 되어");
            Console.WriteLine("아늑한 침대속으로 들어갔다.");
        }

        public override void Next()
        {
            Game.GameOver("");
        }

        public override void Render()
        {
            Console.WriteLine("______            _   _____             _ ");
            Console.WriteLine("| ___ \\          | | |  ___|           | |");
            Console.WriteLine("| |_/ /  ___   __| | | |__   _ __    __| |");
            Console.WriteLine("| ___ \\ / _ \\ / _` | |  __| | '_ \\  / _` |");
            Console.WriteLine("| |_/ /|  __/| (_| | | |___ | | | || (_| |");
            Console.WriteLine("\\____/  \\___| \\__,_| \\____/ |_| |_| \\__,_|");

        }

        public override void Result()
        {
            Game.GameOver("");
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 입력하세요.");
            Console.ReadKey();
        }
    }
}
