using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExample
{
    class Dragon
    {
        //properties
        bool breathsFire;
        bool hasWings;
        string Color;
        int heightInFeet;
        public int health;

        //constructor
        public Dragon()
        {
            breathsFire = true;
            hasWings = true;
            Color = "purple";
            heightInFeet = 30;
        }

        //methods
        public Dragon(bool BreathsFire, bool HasWings, string color, int HeightInFeet)
        {
            BreathsFire = breathsFire;
            HasWings = hasWings;
            color = Color;
            HeightInFeet = heightInFeet;
            health = 1000000;
        }

        //method
        public void Attack(Dragon otherDragon)
        {
            if (breathsFire)
            {
                otherDragon.health = otherDragon.health - 9000;
            }
            else
            {
                otherDragon.health = otherDragon.health - 1;
            }
        }
    }
}
