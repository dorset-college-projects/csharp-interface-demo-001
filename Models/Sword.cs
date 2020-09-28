using InterfaceDemoGameItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemoGameItems.Models
{
    class Sword : IItem, IDamageable, IPartOfQuest
    {
        public Sword(string _name )
        {
            name = _name;
            goldValue = 100;
        }

        public string name { get ; set ; }
        public int goldValue { get; set; }
        public int durability { get ; set; }

        public void Equip()
        {
            Console.WriteLine($"{name} is equipped");
        }

        public void Sell()
        {
            Console.WriteLine($"{name} sold for {goldValue} units ");
        }

        public void TakeDamage(int _dmg)
        {
            durability -= _dmg;
            goldValue -= 5;
            Console.WriteLine($"{name} damaged by {_dmg} and durability is now {durability}");
        }

       
        public void TurnIn()
        {
            Console.WriteLine($"{name} is being turned in as part of quest");

        }
    }
}
