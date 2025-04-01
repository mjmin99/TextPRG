namespace TextRPG
{
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        //아이템 추가
        public void AddItem(Item item)
        {
            items.Add(item);
            Util.Print($"{item.Name}을/를 주머니에 넣었습니다.", ConsoleColor.Blue, delay: 1000);
            Console.WriteLine();
        }

        //아이템 제거
        public void RemoveItem(string itemName)
        {
            Item item = GetItem(itemName);

            if (item != null)
            {
                items.Remove(item);
                Util.Print($"{item.Name}을/를 사용했습니다.", ConsoleColor.Blue, delay: 1000);
            }
        }

        //아이템 반환
        public Item GetItem(string itemName)
        {
            return items.Find(item => item.Name == itemName);
        }

        //아이템 조회
        public void ViewItems()
        {
            Util.Print("<<보유 아이템>>");
            int num = 1;

            if (items.Count == 0)
            {
                Util.Print("없음");
                return;
            }
            foreach (Item item in items)
            {
                Util.Print($"{num++}. {item.Name} : {item.Description}");
            }
        }

    }
}