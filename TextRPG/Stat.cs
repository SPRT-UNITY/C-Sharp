using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Stat
    {
        public int MaxHP { get; protected set; }
        public int CurHP { get; protected set; }
        public int ATK { get; protected set; }
        public int DEF { get; protected set; }

        public int INS { get; protected set; }

        public Stat()
        {
            // default stat
            MaxHP = 100;
            CurHP = 100;
            ATK = 10;
            DEF = 5;
            INS = 0;
        }

        public static Stat operator +(Stat s1, Stat s2)
        {
            if (s1 == null)
                return s2;
            if (s2 == null)
                return s1;

            Stat totalStat = new Stat();
            totalStat.MaxHP = s1.MaxHP + s2.MaxHP;
            totalStat.ATK = s1.ATK + s2.ATK;
            totalStat.DEF = s1.DEF + s2.DEF;
            return totalStat;
        }

        public void AddStat(Stat up) 
        {
            this.MaxHP += up.MaxHP;
            this.ATK += up.ATK;
            this.DEF += up.DEF;
            this.INS += up.INS;
        }

        public void AddHealth(int point) 
        {
            if(point > 0)
                CurHP += point;
        }

        public void DecHealth(int point) 
        {
            if(point > 0)
                CurHP -= point;
        }
    }
}
