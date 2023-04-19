using System;

namespace GameSix
{
    //Enemy maker
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
    

        //Constructor
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        //Name checker
        public string GetName()
        {
            //Tells you the name
            return name;
        }

        //Name setter
        public void SetName(string name)
        {

        }

        //Health checker
        public string GetHealth()
        {
            //Tells you the health amount
            return health;
        }

        //Shield checker
        public string GetShield()
        {
            //Tells you the shield amount
            return shield;
        }

        //When taking damage
        public void TakeDamage(float damage)
        {
            //Shield reduces damage first
            shield -= damage;
            //If shield is 0
            if (shield < 0)
            {
                //Whatever damage is left after shield is destroyed
                float damageStillToInflict = -shield;
                //make sure shield is at 0
                shield = 0;
                //Health takes leftover damage
                health -= damageStillToInflict;
                //If health is below 0 then have it be 0
                if (health < 0) health = 0;
            }
        }
    }
}
