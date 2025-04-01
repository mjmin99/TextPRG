using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class CounselingRoomScene : Scene
    {
        private static List<Item> items = new List<Item>() {new Item("볼펜", "그냥 평범한 볼펜이다.")};
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
                    Console.WriteLine("(쿵쿵쿵)");
                    Console.WriteLine("매니저님이 다가와 말을 걸었다.");
                    Console.WriteLine("\"안녕하세요~ 저희 경일게임아카데미는 비전공자도\"");
                    Console.WriteLine("\"다들 취업이 잘 되고요 교육비도 국비지원을 받아서\"");
                    Console.WriteLine("\"전액 무료로 다니실 수 있습니다. 이번부터는 온라인 클래스\"");
                    Console.WriteLine("\"도 열려서 지역에 상관없이 화상으로도 진행이 되고 있습니다......\"");
                    Console.WriteLine("분위기에 휩쓸려 원서를 작성했다. 원서를 작성하고 볼펜 한자루를 훔쳤다.");
                    Console.WriteLine("날 보는 매니저님의 눈빛이 느껴진다...");

                    Game.Player.inventory.AddItem(items[0]);

                    // Game.Player.Speed += 3;
                    //Console.WriteLine("플레이어 스탯 상승! 속도 : {0}", Game.Player.Speed);

                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 문으로 보이는 통로를 따라 어두운 길을 걸어갔습니다.");
                    Console.WriteLine("사회로 돌아간 당신은 아무것도 변하지 않은 채 집으로 향했습니다.");
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
