using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player count: ");
            int playerCount = int.Parse(Console.ReadLine());
            Team team = new Team("United");

            //Counting players in team and adding player to the team, FirstTeam/Reserve team
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("Add player: ");
                string[] input = Console.ReadLine().Split();
                //Input a player with his FirstName, LastName, Age and Salary
                Player currentPlayer = new Player(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
                team.AddPlayer(currentPlayer);
            }

            //Printing to console number of players for each team
            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");

            Console.ReadLine();
        }
    }
}
