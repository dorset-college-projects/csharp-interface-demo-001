using InterfaceDemoGameItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemoGameItems.Models
{
    class Axe : IItem
    {

        public string name { get; set; }
        public int goldValue { get; set; }

        public Axe(string _name)
        {
            name = _name;
            goldValue = 50;
        }
        public void Equip()
        {
            Console.WriteLine($"{name} is equipped");
        }

        public void Sell()
        {
            Console.WriteLine($"{name} sold for {goldValue} units ");
        }
    }
}
