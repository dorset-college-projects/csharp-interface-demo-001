using InterfaceDemoGameItems.Models;
using System;

namespace InterfaceDemoGameItems
{
    class Program
    {
        static void Main(string[] args)
        {

            Sword mySword = new Sword("Big Golden Sword");
            mySword.Equip();
            mySword.TakeDamage(5);
            mySword.Sell();


            Axe myAxe = new Axe("Small Silver Axe");
            myAxe.Equip();
            myAxe.Sell();
            Console.ReadKey();
        }
    }
}
