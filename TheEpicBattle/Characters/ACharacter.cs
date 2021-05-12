using System;

namespace TheEpicBattle.Characters
{
    public abstract class ACharacter
    {
        private Random random;
        public string Name { get; private set; }
        public double Life { get; private set; }

        protected int Strenght { get; private set; }
        protected int Spirit { get; private set; }
        protected int Dexterity { get; private set; }
        protected int DodgePercent { get; private set; }

        public ACharacter(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent)
        {
            random = new Random();
            Name = name;
            Life = life;

            Strenght = strenght;
            Spirit = spirit;
            Dexterity = dexterity;
            DodgePercent = dodgePercent;
        }

        public abstract void Attack(ACharacter opponent);

        public void BeingAttacked(double damage)
        {
            if (Dodge())
                return;

            TookDamage(damage);
        }

        private bool Dodge()
        {
            var luck = random.Next(0, 101); // 0 => 100

            if (luck < DodgePercent)
            {
                Console.WriteLine($"##### {Name} à esquivé ! #####");
                return true;
            }
            return false;
        }

        private void TookDamage(double damage)
        {
            Life -= damage;

            Console.WriteLine($"{Name} à pris {damage} points de dégats.");

            if (Life <= 0)
            {
                Console.WriteLine($"##### {Name} est mort ! #####");
                return;
            }    
        }
    }
}
