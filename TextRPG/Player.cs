using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    public enum Job 
    {
        None, Swordman, Magician, Bowman
    }

    public class Player : Unit
    {
        public Job job { get; private set; }
        public int gold { get; private set; }
        public int expBar { get { return level * 100; } }
        public int curExp { get; private set; }

        public Equipment weapon { get; private set; }
        public Equipment armor { get; private set; }

        public override Stat RealtimeStat { get { return stat + weapon.stat + armor.stat; } }

        public Player() 
        {
            // default
            name = "Jackson";
            job = Job.None;
            gold = 0;
            curExp = 0;
        }

        public void LoadPlayerData() 
        {
            
        }

        public void SavePlayerData() 
        {
            
        }

        public void GainEXP(int exp) 
        {
            Console.WriteLine($"경험치를 {exp}만큼 얻었습니다.");
            curExp += exp;
            if(curExp > expBar) 
            {
                LevelUp();
            }
        }

        public void AddGold(int add) 
        {
            gold += add;
        }

        public void RemoveGold(int remove) 
        {
            if(gold < remove) 
            {
                throw new Exception("Gold Cannot be under 0");
            }
            gold -= remove;
        }

        public void LevelUp() 
        {
            level++;
            Console.WriteLine($"레벨이 올랐습니다! 레벨이 {level}이 되었습니다.");
        }

        public void PrintStat() 
        {
            Console.WriteLine("플레이어의 현재 정보입니다.");
            Console.WriteLine($"Lv.{level}");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"직업 : {job.ToString()}");
            Console.WriteLine($"공격력 : {RealtimeStat.ATK}");
            Console.WriteLine($"방어력 : {RealtimeStat.DEF}");
            Console.WriteLine($"최대 체력 : {RealtimeStat.ATK}");
            Console.WriteLine($"현재 체력 : {stat.CurHP}");
        }

        public void EquipWeapon(Equipment weapon) 
        {
            this.weapon = weapon;
        }

        public void EquipArmor(Equipment armor) 
        {
            this.armor = armor;
        }
    }
}
