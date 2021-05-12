using System;
using System.Collections.Generic;
using System.Linq;
using TheEpicBattle.Characters;
using TheEpicBattle.Teams;
using TheEpicBattle.Weapons;

namespace TheEpicBattle
{
    class Program
    {
        private static List<Team> Teams = new List<Team>();

        static void Main(string[] args)
        {
            /*
             * DE MULTIPLES équipes, composées chacune de PLUSIEURS combattants
             * Les combattants peuvent être soit :
             * - Humains (Arme)
             * - Nains (Arme)
             * - Animaux (Pas d'arme)
             * - Monstre (Arme + Frenesie)
             * 
             * Types d'Armes :
             * - Force
             * - Dexterité
             * - Esprit
             * 
             * Armes :
             * - (Force) => épée, hache
             * - (Dexterité) => Arc, Arbalette
             * - (Esprit) => Baton, Livre
             * 
             * Stats combattants :
             * - Nom
             * - Vie
             * - Force
             * - Esprit
             * - Dexterité
             * - Esquive
             * - Frenesie
             * 
             * But de la bataille :
             * Fonctionnement par Round, chaque round => chacuns des combattants doit attaquer un adversaire d'une des équipes adverses.
             * Mort de l'équipe quand plus aucun combattant n'a de vie
             * Fin de la bataille quand une seule équipe restante.
            */

            var destinyBook = new Book("Grimoire de la destinée", 4);
            var toolgunStaff = new Staff("Toolgun", 10);
            var woodenAxe = new Axe("Hache en bois", 1);
            var silverSword = new Sword("L'épée d'argent", 6);
            var lordBow = new Bow("Arc du seigneur déchu", 7);
            var southParkCrossbow = new Crossbow("Arbalette de SouthPark : Stick of Truth", 1);
            

            var team1 = new Team("Yoloswag");
            var team2 = new Team("Les Lockers");
            var team3 = new Team("Halo POWA");

            team1.Members.Add(new Dwarf("Roger De Paris", 100, 2, 10, 3, 10, destinyBook));
            team1.Members.Add(new Human("Patrick De Paris", 100, 2, 10, 3, 10, woodenAxe));
            team1.Members.Add(new Animal("Dagobert", 100, 2, 10, 3, 10));

            team2.Members.Add(new Monster("Satan", 100, 2, 10, 3, 10, 50, southParkCrossbow));
            team2.Members.Add(new Monster("Belzebut", 100, 2, 10, 3, 10, 90, silverSword));
            team2.Members.Add(new Animal("Gean", 100, 2, 10, 3, 10));


            team3.Members.Add(new Human("Belzebut", 100, 2, 10, 3, 10, silverSword));
            team3.Members.Add(new Monster("Belzebut", 100, 2, 10, 3, 10, 90, lordBow));
            team3.Members.Add(new Monster("Belzebut", 100, 2, 10, 3, 10, 90, toolgunStaff));
            team3.Members.Add(new Animal("Yves", 100, 2, 10, 3, 10));
            team3.Members.Add(new Animal("Croissant", 100, 2, 10, 3, 10));
            team3.Members.Add(new Animal("Garry", 100, 2, 10, 3, 10));

            Teams.Add(team1);
            Teams.Add(team2);
            Teams.Add(team3);

            StartBattle();
        }

        private static void StartBattle()
        {
            while (Teams.Count(team => team.Members.Any(member => member.Life > 0)) >= 2)
            {
                foreach (var team in Teams)
                    StartTeamAttack(team);
            }
            var winner = Teams.SingleOrDefault(team => team.Members.Any(member => member.Life > 0));
            Console.WriteLine($"########## L'EQUIPE VAINQUEUR EST {winner.Name.ToUpper()} !! ##########");
        }

        private static bool StartTeamAttack(Team team)
        {
            var opponentTeams = Teams.Where(t => t != team && t.Members.Any(member => member.Life > 0)).ToList();

            if (!opponentTeams.Any())
            {
                Console.WriteLine($"Toutes les equipes adverses ont été vaincues.");
                return false;
            }

            foreach (var member in team.Members.Where(member => member.Life > 0))
            {
                var opponentTeam = opponentTeams.First();
                var opponent = opponentTeam.Members.FirstOrDefault(x => x.Life > 0);
                if (opponent == null)
                {
                    Console.WriteLine($"{Environment.NewLine}Tout les membres de l'équipe {opponentTeam.Name} ont été vaincus{Environment.NewLine}");
                    return true;
                }
                //Pour chaque membre en vie on attaque le premier membre en vie de la première équipe adverse
                Console.WriteLine($"Attack de {member.Name} de l'équipe {team.Name} sur le combattant {opponent.Name} de l'équipe {opponentTeam.Name}");
                member.Attack(opponent);
            }
            return true;
        }
    }
}
