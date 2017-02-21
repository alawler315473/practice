using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourGod
{
    class Program
    {
        static void Main(string[] args)
        {
            int mPower;
            int pPower;
            int health;
            int mana;
            int baseAttDamage;
            int moveSpeed;
            double attSpeed;
            int cdReduct;
            int ccReduct;
            int mgDef;
            int phDef;

            Console.WriteLine(" Hello player, please choose a Class you would like to take part in \n ");
            Console.WriteLine(" Classes: \n \n Mage \n Hunter \n Warrior \n Guardian \n Assassin \n ");
            string playerInput = Console.ReadLine();
            Console.WriteLine();

            
            {

                if (playerInput == "Mage")
                {
                    Console.Clear();

                    mPower = 100;
                    health = 1300;
                    mana = 2600;
                    baseAttDamage = 50;
                    moveSpeed = 30;
                    attSpeed = .80;
                    mgDef = 10;
                    phDef = 10;

                    Console.WriteLine(" These are your base stats as a Mage, you'll be able to upgrade \n them later on dependding on what god you pick. \n\n");
                    Console.WriteLine("Pyhcical Power: " + mPower + "/1000\n");
                    Console.WriteLine(" Health: " + health + "/10,000\n");
                    Console.WriteLine(" Mana: " + mana + "/10,000\n");
                    Console.WriteLine(" Basic Attack Damage: " + baseAttDamage + "/500\n");
                    Console.WriteLine(" Movement Speed: " + moveSpeed + "/100\n");
                    Console.WriteLine(" Attack Speed: " + attSpeed + "/2.50\n");
                    Console.WriteLine(" Magical Defense: " + mgDef + "/400\n");
                    Console.WriteLine(" Physical Defense: " + phDef + "/400\n");
                    

                }
                else if (playerInput == "Hunter")
                {
                    Console.Clear();

                    pPower = 120;
                    health = 1200;
                    mana = 1300;
                    baseAttDamage = 100;
                    moveSpeed = 60;
                    attSpeed = 2.20;
                    mgDef = 10;
                    phDef = 10;

                    Console.WriteLine(" These are your base stats as a Mage, you'll be able to upgrade \n them later on dependding on what god you pick. \n\n");
                    Console.WriteLine("Pyhcical Power: " + pPower + "/1000\n");
                    Console.WriteLine(" Health: " + health + "/10,000\n");
                    Console.WriteLine(" Mana: " + mana + "/10,000\n");
                    Console.WriteLine(" Basic Attack Damage: " + baseAttDamage + "/500\n");
                    Console.WriteLine(" Movement Speed: " + moveSpeed + "/100\n");
                    Console.WriteLine(" Attack Speed: " + attSpeed + "/2.50\n");
                    Console.WriteLine(" Magical Defense: " + mgDef + "/400\n");
                    Console.WriteLine(" Physical Defense: " + phDef + "/400\n");
                    
                }
                else if (playerInput == "Warrior")
                {
                    Console.Clear();

                    pPower = 160;
                    health = 1800;
                    mana = 1400;
                    baseAttDamage = 115;
                    moveSpeed = 20;
                    attSpeed = .60;
                    mgDef = 20;
                    phDef = 20;

                    Console.WriteLine(" These are your base stats as a Mage, you'll be able to upgrade \n them later on dependding on what god you pick. \n\n");
                    Console.WriteLine("Pyhcical Power: " + pPower + "/1000\n");
                    Console.WriteLine(" Health: " + health + "/10,000\n");
                    Console.WriteLine(" Mana: " + mana + "/10,000\n");
                    Console.WriteLine(" Basic Attack Damage: " + baseAttDamage + "/500\n");
                    Console.WriteLine(" Movement Speed: " + moveSpeed + "/100\n");
                    Console.WriteLine(" Attack Speed: " + attSpeed + "/2.50\n");
                    Console.WriteLine(" Magical Defense: " + mgDef + "/400\n");
                    Console.WriteLine(" Physical Defense: " + phDef + "/400\n");
                    
                }
                else if (playerInput == "Assassin")
                {
                    Console.Clear();

                    pPower = 180;
                    health = 1200;
                    mana = 1250;
                    baseAttDamage = 200;
                    moveSpeed = 80;
                    attSpeed = 1.5;
                    mgDef = 10;
                    phDef = 10;

                    Console.WriteLine(" These are your base stats as a Mage, you'll be able to upgrade \n them later on dependding on what god you pick. \n\n");
                    Console.WriteLine("Pyhcical Power: " + pPower + "/1000\n");
                    Console.WriteLine(" Health: " + health + "/10,000\n");
                    Console.WriteLine(" Mana: " + mana + "/10,000\n");
                    Console.WriteLine(" Basic Attack Damage: " + baseAttDamage + "/500\n");
                    Console.WriteLine(" Movement Speed: " + moveSpeed + "/100\n");
                    Console.WriteLine(" Attack Speed: " + attSpeed + "/2.50\n");
                    Console.WriteLine(" Magical Defense: " + mgDef + "/400\n");
                    Console.WriteLine(" Physical Defense: " + phDef + "/400\n");
                    
                }
                else if (playerInput == "Guardian")
                {
                    Console.Clear();

                    mPower = 50;
                    health = 3100;
                    mana = 1800;
                    baseAttDamage = 50;
                    moveSpeed = 15;
                    attSpeed = .20;
                    mgDef = 100;
                    phDef = 100;

                    Console.WriteLine(" These are your base stats as a Guardian, you'll be able to upgrade \n them later on dependding on what god you pick. \n\n");
                    Console.WriteLine(" BASIC STATS: ");
                    Console.WriteLine("Pyhcical Power: " + mPower + "/1000\n");
                    Console.WriteLine(" Health: " + health + "/10,000\n");
                    Console.WriteLine(" Mana: " + mana + "/10,000\n");
                    Console.WriteLine(" Basic Attack Damage: " + baseAttDamage + "/500\n");
                    Console.WriteLine(" Movement Speed: " + moveSpeed + "/100\n");
                    Console.WriteLine(" Attack Speed: " + attSpeed + "/2.50\n");
                    Console.WriteLine(" Magical Defense: " + mgDef + "/400\n");
                    Console.WriteLine(" Physical Defense: " + phDef + "/400\n");
                    Console.WriteLine("Pick your Guardian below \n\n\n");
                    
                }
                if (playerInput == "Guardian")
                {
                    Console.WriteLine("Now you get to pick your Guardian! \nchoose from the selection\n\n\n\n\n\n");

                    Console.WriteLine("Slyvanus: \n");
                    Console.WriteLine("PASSIVE: ");
                    Console.WriteLine("Any enemy that damages Slyvanus gives him a 20% chance to heal him \n");
                    Console.WriteLine("ABILITIES: \n\n Healing Wisp: Heal himself and nerby players. \n Vine Root: Srows a powerful viylvanus thne, rooting and stunning enemies \n in its proximity. \n Vine Grab: Slyvanus grabs an enemy with a powerfull vine, pulling the enemy to him while reducing their protections and slowing them for a short time \n\n ULTIMATE ABILITY \n\n Natures Poison: Slvanus Wraps enemies in his tree roots \n stunning, posioning, and reducing their healing for a short period. \n\n\n\n\n\n");


                    Console.WriteLine("Baccus: The God of Wine \n");
                    Console.WriteLine("PASSIVE: ");
                    Console.WriteLine("Everytime Baccus drinks, he get increased proctections and magical power until the meter goes down,\n drinking will increase the bar based on its recent location\n\n ");
                    Console.WriteLine("ABILITES: \n");
                    Console.WriteLine("Bottoms up: Baccus drinks wine, increasing his drunk meter,\n and increasing his magical power for a short period of time.");
                    Console.WriteLine("Belly Flop: Baccus Leaps into the air, damaging and knocking up any enemy \n in the area of the impact. ");
                    Console.WriteLine("Powerfull Burp: Baccus sends out a load and powerfull burp, causing \n ticking damage. At the end of the burp, the enemy targets are stunned and slowed.\n");
                    Console.WriteLine("ULTIMATE ABILITY: ");
                    Console.WriteLine("Lets get wasted!: Baccus slames his wine on the ground in celebration, damaging and intoxicating the ground for nearby enemies,\n Baccus also gains increased magical power during this time.\n\n\n\n\n\n");


                    Console.WriteLine("Kumbhakarna: The Sleeping Giant \n");
                    Console.WriteLine("ABILITIES: ");
                    Console.WriteLine("Belly Bump: Kumbhakarna dashes forward and belly bumps an enemy, \n damaging them while sending them flying back. ");
                    Console.WriteLine("Mighty Yawn: Kumbhakarna sends out a mighty yawn, stunning all enemies \n around him while buffing himself with increased attck speed and power. ");
                    Console.WriteLine("Club Slam: Kumbhakarna slams his club against the ground making \n the ground vibrate and tremble underneath enemies, disorientating them for a \n short period.\n If the staff hits the directly, Kumba does x2 the damage on his next ability.\n\n\n\n\n\n");
                    Console.WriteLine("ULTIMATE ABLITY:");

                }

            }
        }
    }
}
