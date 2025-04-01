using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class CounselingRoomScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 학원등록하기 ");
            Console.WriteLine("2. 지금 문을 열고 밖으로 나가기");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("CounselingRoom2");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Bedending");
                    break;
            }
        
        }

        public override void Render()
        {
            Console.WriteLine("사방이 어둡다...");
            Console.WriteLine("기억을 잃어버렸다가 눈을 뜬 곳은...");
            Console.WriteLine("\"경일게임아카데미...\"");
            Console.WriteLine("잘은 모르겠지만 여길 탈출해야 할 것 같다.");
            Console.WriteLine("");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("신발을 구매합니다.");
                    Console.WriteLine("착용하니 당신의 다리가 가벼워지는 것을 느낍니다.");
                    Game.Player.Speed += 3;
                    Console.WriteLine("플레이어 스탯 상승! 속도 : {0}", Game.Player.Speed);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 문으로 보이는 통로를 따라 어두운 길을 걸어갔습니다.");
                    Console.WriteLine("사회로 돌아간 당신은 자신에게 일어난 변화를 눈치채지 못한채 집으로 향했습니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 입력하세요.");
            Console.ReadKey();
        }
    }
}
