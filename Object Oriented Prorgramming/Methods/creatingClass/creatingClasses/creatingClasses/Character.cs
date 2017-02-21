using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingClasses
{
    class Character
    {
        //properties
        int health;
        string weapon;
        string offHand;
        string armorType;

        //constructor
        public Character()
        {
            health = 100;
            weapon = "rusty sword";
            offHand = "wooden shield";
            armorType = "cloth";
        }
        public Character(int Health, string Weapon, string OffHand, string ArmorType)
        {
            Health = health;
            Weapon = weapon;
            OffHand = offHand;
            ArmorType = armorType;
        }

        //methods
        public int GetTotalDamage(Character character)
        {
            if ("rusty sword" == character.weapon)
            {
                return 100;
            }
            else if ("wooden shield" == character.offHand)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        //methods
        public int GetTotalArmor(Character charactor)
        {
            if("rusty sword" == charactor.weapon)
            {
                return 0;
            }
            else if ("cloth" == charactor.armorType)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
