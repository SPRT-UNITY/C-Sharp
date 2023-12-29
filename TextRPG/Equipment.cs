using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public enum EquipmentType 
    {
        Weapon, Armor
    }
    public class Equipment : Item
    {
        public Stat stat {  get; private set; }
    }
}
