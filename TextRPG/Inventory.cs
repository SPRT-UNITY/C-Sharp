using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Inventory
    {
        public List<Item> items { get; private set; }

        public void AddItem(Item item) 
        {
            items.Add(item);
        }

        public void RemoveItem(int index) 
        {
            // 아이템을 다룰 때에는 내부 인덱스로 함께 움직이도록 함
            items.RemoveAt(index);
        }

        public List<(Equipment, int)> GetEquipmentListFromInventory() 
        {
            List <(Equipment, int)> list = new List<(Equipment, int)>();
            for(int i = 0; i<items.Count; i++)
            {
                if(items[i] is Equipment) 
                {
                    list.Add((items[i] as Equipment, i));
                }
            }
            return list;
        }
    }
}
