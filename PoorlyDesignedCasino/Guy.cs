using System;
using System.Collections.Generic;
using System.Text;

namespace PoorlyDesignedCasino
{
    class Guy
    {
        public string Name;
        public int Cash;

      
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " dollars.");
        }

   
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " +
                    "You don't have " + amount + " dollars");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

      
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
