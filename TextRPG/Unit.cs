using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Unit
    {
        public Unit() 
        {
            // default stats;
            level = 0;
            stat = new Stat();
        }

        public string name { get; protected set; }
        public int level { get; protected set; }
        public int CurHP { get { return stat.CurHP; } }
        public Stat stat { get; protected set; }

        public virtual Stat RealtimeStat { get { return stat; } }

        public void GiveDamage(Unit target) 
        {
            target.TakeDamage(new Random().Next(RealtimeStat.ATK - RealtimeStat.INS, RealtimeStat.ATK + RealtimeStat.INS));
        }

        public void TakeDamage(int damage) 
        {
            stat.DecHealth(damage - RealtimeStat.DEF);

            if(stat.CurHP <= 0) 
            {
                Dead();
            }
        }

        public virtual void Dead() 
        {
            // 으앙 쥬금
        }
    }
}
