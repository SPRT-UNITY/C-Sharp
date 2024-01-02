using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Map
    {
        protected List<(Action, string)> decisions = new List<(Action, string)>();
        protected List<string> messages = new List<string> ();
        public void InitMap()
        {

        }

        public void EnterMap(List<(Action, string)> decisions, Player player)
        {

        }

        public void ExitMap()
        {

        }
    }

    public class Shop : Map
    {
        List<Item> items = new List<Item>();
        public void InitShop() 
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Game.game.defaultPlayer.gold}");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            foreach(var item in items) 
            {
                Console.WriteLine($"- {item.name} | {item.effectScript} | {item.desc} | {item.value}");
            }
        }
    }

    public class Field : Map
    {

    }

    public class Dungeon : Map
    {

    }
}
