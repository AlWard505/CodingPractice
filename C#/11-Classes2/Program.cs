﻿using System;
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
                Console.WriteLine("enter difficult for enemy " + z + "\ne is easy\nm is medium\nh is hard");
                enemies.Add(new Enemy(Console.ReadLine()));
            }
            while (true)
            {
                Console.WriteLine("which enemy do you want to damage");
                int x = 0;
                foreach(var enemy in enemies)
                {
                    
                    Console.WriteLine("enemy "+ Convert.ToString(x));
                    Console.WriteLine("health: " + enemy.Health);
                    x += 1;
                }
                int attacked = int.Parse(Console.ReadLine());
                Console.WriteLine("how much damage");
                enemies[attacked].damage(int.Parse(Console.ReadLine()));
                if (enemies[attacked].Health <= 0)
                {
                    Console.WriteLine("the enemy is dead");
                    enemies.RemoveAt(attacked);
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
                Damage.Add(-(rnd.Next(5, 10)));
            }
            else if (strength == "m")
            {
                Damage.Add(-(rnd.Next(10, 15)));
            }
            else if (strength == "h")
            {
                Damage.Add(-(rnd.Next(15, 20)));
            }
        }

        public void damage(int DamageTaken)
        {
            Damage.Add(DamageTaken);
            
        }
    }

    
}
