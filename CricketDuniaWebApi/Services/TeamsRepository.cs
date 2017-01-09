using CricketDuniaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricketDuniaWebApi.Services
{
    public class TeamsRepository
    {
        public Team[] GetAllTeamsDetails()
        {
            return MockDataRepository.MockData.GetTeamsDetails();
        }

        public Team GetTeamDetails(string teamId)
        {
            return GetAllTeamsDetails().Where(x => x.TeamId.Equals(teamId.ToUpper())).First();
        }
    }
}