using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricketDuniaWebApi.Models
{
    public class Team
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public TestStats TestStatsDetails { get; set; }
        public OdiStats OdiStatsDetails { get; set; }
    }
}