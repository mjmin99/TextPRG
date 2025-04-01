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
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃ 경일게임아카데미탈출 사건 (부제) 희망이 보이지 않는다 ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Wait() { }
    }
}
