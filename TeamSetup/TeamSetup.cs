using System.Collections.Generic;
using System.Linq;

namespace TeamSetup
{
    public class TeamSetup
    {
        public List<People> List;

        public TeamSetup(List<People> source)
        {
            List = source;
        }

        private Teams GenerateTeams(int totalTeams)
        {
            Teams teams = new Teams();

            for (int i = 0; i < totalTeams; i++)
            {
                teams.Team.Add(new List<People>());
            }

            return teams;
        }

        public Teams SetupTeams(int teamsInTotal)
        {
            var teams = GenerateTeams(teamsInTotal);

            var list = List.OrderByDescending(p => p.Rank);
            var index = 0;

            foreach (var teamMember in list)
            {
                if (index % teamsInTotal == 0)
                {
                    index = 0;                    
                }

                teams.Team[index].Add(teamMember);
                index++;
            }

            return teams;
        }
    }
}