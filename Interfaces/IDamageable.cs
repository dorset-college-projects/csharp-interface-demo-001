using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemoGameItems.Interfaces
{
    interface IDamageable
    {
        int durability { get; set; }
        void TakeDamage(int _amount);
    }
}
