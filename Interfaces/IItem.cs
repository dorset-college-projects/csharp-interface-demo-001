using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemoGameItems.Interfaces
{
    interface IItem
    {
        string name { get; set; }
        int goldValue { get; set; }

        void Equip();
        void Sell();
    }
}
