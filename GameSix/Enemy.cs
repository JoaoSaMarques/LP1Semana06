using System;

namespace GameSix
{
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

        public string GetName()
        {
            return name;
        }

        public string GetHealth()
        {
            return health;
        }

        public string GetShield()
        {

        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
    }
}
