using CricketDuniaWebApi.Models;
using CricketDuniaWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CricketDuniaWebApi.Controllers
{
    public class TeamsController : ApiController
    {
        private TeamsRepository teamsRepository;
        public TeamsController()
        {
            this.teamsRepository = new TeamsRepository();
        }
    [HttpGet]
        public Team[] GetAllTeamsDetails()
        {
            return this.teamsRepository.GetAllTeamsDetails();
        }
        [HttpGet]
        public Team GetTeamDetails (string id)
        {
            return this.teamsRepository.GetTeamDetails(id);
        }
    }
}
