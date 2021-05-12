namespace TheEpicBattle.Characters
{
    public class Animal : ACharacter
    {
        public Animal(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent) : base(name, life, strenght, spirit, dexterity, dodgePercent)
        {
        }

        public override void Attack(ACharacter opponent)
        {
            opponent.BeingAttacked(Strenght);
        }
    }
}
