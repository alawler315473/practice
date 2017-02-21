using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Player
    {
        protected int health;
		protected int attack;
		protected int magicAbility;
		protected int magicPts;
		protected int actionPts;
		protected int maxHealth;
		
		public Player(int health,int attack,int magicAbility,int magicPts, int actionPts)
		{
			this.health = health;
			maxHealth = health;
			this.attack = attack;
			this.magicPts = magicPts;
			this.magicAbility = magicAbility;
			this.actionPts = actionPts;
		}
		public void TakeDamage(int damage){
			health -= damage;
		}
        public bool IsAlive()
        {
            return health > 0;
        }
		public virtual bool Heal(){
			
			if(magicPts>10){
				health += 20;
				if(health > maxHealth){
					health = maxHealth;
				}
				magicPts-=10;
				return true;
			}
			return false;
		}
		
		public virtual bool Fireball(Player player)
		{
			if(magicPts>20){
				player.TakeDamage(30);
				magicPts-=20;
				return true;
			}
			return false;
		}
		public virtual bool Attack(Player player)
		{
			if(actionPts>10)
			{
				player.TakeDamage(20);
				actionPts-=10;
				return true;
			}
			return false;
		}
		public virtual bool Meditate()
		{
			if (actionPts >5){
				magicPts +=10;
				actionPts -=5;
				return true;
			}
			return false;
		}
		public virtual bool Rest()
		{
			actionPts +=10;
			return true;
		}		
    }
}
