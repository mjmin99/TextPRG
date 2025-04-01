using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public class TitleScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
            }
        }

        public override void Render()
        {
            Console.WriteLine(" _____                                   __                         ");
            Console.WriteLine("|  ___|                                 / _|                         ");
            Console.WriteLine("| |__   ___   ___   __ _  _ __    ___  | |_  _ __   ___   _ __ ___   ");
            Console.WriteLine("|  __| / __| / __| / _` || '_ \\  / _ \\ |  _|| '__| / _ \\ | '_ ` _ \\  ");
            Console.WriteLine("| |___ \\__ \\| (__ | (_| || |_) ||  __/ | |  | |   | (_) || | | | | | ");
            Console.WriteLine("\\____/ |___/ \\___| \\__,_|| .__/  \\___| |_|  |_|    \\___/ |_| |_| |_|");
            Console.WriteLine("                         | |                                         ");
            Console.WriteLine("                         |_|                                         ");
            Console.WriteLine();
            Console.WriteLine(" _   __                             _  _      ___                    _                         ");
            Console.WriteLine("| | / /                            (_)| |    / _ \\                  | |                        ");
            Console.WriteLine("| |/ /  _   _  _   _  _ __    __ _  _ | |   / /_\\ \\  ___   __ _   __| |  ___  _ __ ___   _   _ ");
            Console.WriteLine("|    \\ | | | || | | || '_ \\  / _` || || |   |  _  | / __| / _` | / _` | / _ \\| '_ ` _ \\ | | | |");
            Console.WriteLine("| |\\  \\| |_| || |_| || | | || (_| || || |   | | | || (__ | (_| || (_| ||  __/| | | | | || |_| |");
            Console.WriteLine("\\_| \\_/ \\__, | \\__,_||_| |_| \\__, ||_||_|   \\_| |_/ \\___| \\__,_| \\__,_| \\___||_| |_| |_| \\__, |");
            Console.WriteLine("         __/ |                __/ |                                                       __/ |");
            Console.WriteLine("        |___/                |___/                                                       |___/ ");












        } // 오프닝 타이틀

        public override void Result() { }

        public override void Wait() { }
    }
}
