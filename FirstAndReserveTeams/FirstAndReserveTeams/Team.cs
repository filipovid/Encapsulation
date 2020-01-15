using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeams
{
    class Team
    {
        private string _name;
        private List<Player> _firstTeam;
        private List<Player> _reserveTeam;

        public Team(string name)
        {
            _name = name;
            _firstTeam = new List<Player>();
            _reserveTeam = new List<Player>();
        }

        public IReadOnlyCollection<Player> FirstTeam
        {
            get { return _firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Player> ReserveTeam
        {
            get { return _reserveTeam.AsReadOnly(); }
        }

        public void AddPlayer(Player player)
        {
            if (player.Age < 35)
            {
                _firstTeam.Add(player);
            }
            else
            {
                _reserveTeam.Add(player);
            }
        }
    }
}
