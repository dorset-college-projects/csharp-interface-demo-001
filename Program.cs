using InterfaceDemoGameItems.Interfaces;
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

            IItem[] inventory = new IItem[2];

            inventory[0] = mySword;
            inventory[1] = myAxe; 

            for(int i = 0;i < inventory.Length; i++)
            {

                IPartOfQuest questItem = inventory[i] as IPartOfQuest;

                if (questItem != null)
                {
                    questItem.TurnIn();
                }

            }



            Console.ReadKey();
        }
    }
}
