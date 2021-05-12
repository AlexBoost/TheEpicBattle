using System.Collections.Generic;
using TheEpicBattle.Characters;

namespace TheEpicBattle.Teams
{
    public class Team
    {
        public string Name { get; private set; }
        public List<ACharacter> Members { get; } = new List<ACharacter>();

        public Team(string name)
        {
            Name = name;
        }
    }
}
