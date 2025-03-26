using System;

namespace MyGame
{
    public enum PowerUp
    {
        Health,
        Shield
    }

    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        // Constructor
        public Enemy(string name)
        {
            SetName(name); // name oculta this.name
            health = 100;
            shield = 0;
        }

        // Method to set the name with a maximum of 8 characters
        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring(0, 8); // Use only the first 8 chars
            }
            else
            {
                name = newName;
            }
        }

        public string GetName()
        {
            return name;
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

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100) health = 100; // Cap health at 100
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100) shield = 100; // Cap shield at 100
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }
    }
}
