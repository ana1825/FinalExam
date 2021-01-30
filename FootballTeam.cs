using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChempionship
{
    public class FootballTeam
    {
        public int FootballTeamId { get; set; }
        public String teamName { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return teamName + " -> " + score;
        }
    }
}
