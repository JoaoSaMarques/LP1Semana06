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
            //Remove leading and trailing spaces
            this.name = name.Trim();
        }

        //Health checker
        public float GetHealth()
        {
            //Tells you the health amount
            return health;
        }

        //Shield checker
        public float GetShield()
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

        //Pickup Powerup
        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            //If powerup is for health
            if (powerUp == PowerUp.Health)
            {
                //Increase health value
                health += value;
                //Limit health to 100
                if (health > 100) health = 100;
            }
            //If powerup is for shield 
            else if (powerUp == PowerUp.Shield)
            {
                //Increase shield value
                shield += value;
                //Limit shield to 100
                if (shield > 100) shield = 100;
            }
            
        }
    }
}
