using System;
using System.Collections.Generic;
namespace _11_Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();
            Console.WriteLine("how many enemies");
            int quantity = int.Parse(Console.ReadLine());
            for (int z = 0; z< quantity; z++)
            {
                Console.WriteLine("enter difficult for enemy " + Convert.ToInt32(z)+1 + "\ne is easy\nm is medium\nh is hard");
                enemies.Add(new Enemy(Console.ReadLine()));
            }
            while (true)
            {
                Console.WriteLine("which enemy do you want to damage");
                int x = 0;
                foreach(var enemy in enemies)
                {
                    
                    Console.WriteLine("enemy "+ Convert.ToString(x+1));
                    Console.WriteLine("health: " + enemy.Health);
                    x += 1;
                }
                int attacked = int.Parse(Console.ReadLine());
                Console.WriteLine("how much damage");
                enemies[attacked-1].damage(int.Parse(Console.ReadLine()));
                if (enemies[attacked-1].Health <= 0)
                {
                    Console.WriteLine("the enemy is dead");
                    enemies.RemoveAt(attacked-1);
                }
                if (enemies.Count == 0)
                {
                    Console.WriteLine("you win");
                    break;
                }
            }
        }
    }
    class Enemy
    {
        public int Health
        {
            get
            {
                int health = 0;
                foreach(var list in Damage)
                {
                    health += -list;
                }
                return health;
            }
        }
        private List<int> Damage = new List<int>();

        public Enemy(string strength)
        {
            Random rnd = new Random();
            if (strength == "e")
            {
                Damage.Add(-(rnd.Next(5, 11)));
            }
            else if (strength == "m")
            {
                Damage.Add(-(rnd.Next(9, 16)));
            }
            else if (strength == "h")
            {
                Damage.Add(-(rnd.Next(14, 20)));
            }
        }

        public void damage(int DamageTaken)
        {
            Damage.Add(DamageTaken);
            
        }
    }

    
}
