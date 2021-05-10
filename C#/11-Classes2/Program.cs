using System;
using System.Collections.Generic;
namespace _11_Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            var enemys = new Enemy();
            Console.WriteLine(enemys);
            enemys = new Enemy();
            Console.WriteLine(enemys);
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
                    health += list;
                }
                return health;
            }
        }
        private List<int> Damage = new List<int>();

        public Enemy()
        {
            Damage.Add(-10);
        }

        public void damage(int DamageTaken)
        {
            Damage.Add(DamageTaken);
        }
    }

    
}
