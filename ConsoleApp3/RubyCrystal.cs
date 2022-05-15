using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class RubyCrystal : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public RubyCrystal()
        {
            //ustalamy nazwe itemu
            name = "Ruby Crystal";
            // jego cene
            price = 400;
            //i atrybuty
            AddStat(Stat.HP, 150);
        }
        public class GiantsBelt : Item
        {
            //deprecated???
            //public int bonusHP = 350;
            public GiantsBelt()
            {
                //ustalamy nazwe itemu
                name = "Giant's Belt";
                // jego cene
                price = 900;
                //i atrybuty
                AddStat(Stat.HP, 350);
            }
        }
    }
}
