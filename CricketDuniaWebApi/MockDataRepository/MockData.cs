using CricketDuniaWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricketDuniaWebApi.MockDataRepository
{
    public class MockData
    {
        public static Team[] GetTeamsDetails()
        {
            Team[] TeamDetails = new Team[] 
            { 
                new Team() {TeamId="AUS", TeamName = "Australia" , TestStatsDetails= new TestStats(){MatchesPlayed=797, MatchesWon=376}, OdiStatsDetails = new OdiStats(){MatchesPlayed=891, MatchesWon=550}} ,
                new Team() { TeamId="ENG", TeamName = "England" , TestStatsDetails= new TestStats(){MatchesPlayed=983, MatchesWon=351}, OdiStatsDetails = new OdiStats(){MatchesPlayed=677, MatchesWon=328}} ,
                new Team() { TeamId="WI", TeamName = "West Indies" , TestStatsDetails= new TestStats(){MatchesPlayed=520, MatchesWon=165}, OdiStatsDetails = new OdiStats(){MatchesPlayed=748, MatchesWon=377}} ,
                new Team() { TeamId="RSA", TeamName = "South Africa" , TestStatsDetails= new TestStats(){MatchesPlayed=407, MatchesWon=150}, OdiStatsDetails = new OdiStats(){MatchesPlayed=564, MatchesWon=348}} ,
                new Team() { TeamId="IND", TeamName = "India" , TestStatsDetails= new TestStats(){MatchesPlayed=507, MatchesWon=136}, OdiStatsDetails = new OdiStats(){MatchesPlayed=904, MatchesWon=457}} ,
                new Team() { TeamId="PAK", TeamName = "Pakistan" , TestStatsDetails= new TestStats(){MatchesPlayed=407, MatchesWon=130}, OdiStatsDetails = new OdiStats(){MatchesPlayed=866, MatchesWon=457}} ,
                new Team() { TeamId="NZ", TeamName = "New Zealand" , TestStatsDetails= new TestStats(){MatchesPlayed=417, MatchesWon=87}, OdiStatsDetails = new OdiStats(){MatchesPlayed=714, MatchesWon=316}} ,
                new Team() { TeamId="SL", TeamName = "Sri Lanka" , TestStatsDetails= new TestStats(){MatchesPlayed=255, MatchesWon=80}, OdiStatsDetails = new OdiStats(){MatchesPlayed=782, MatchesWon=368}} ,
                new Team() { TeamId="ZIM", TeamName = "Zimbabwe" , TestStatsDetails= new TestStats(){MatchesPlayed=101, MatchesWon=11}, OdiStatsDetails = new OdiStats(){MatchesPlayed=479, MatchesWon=123}} ,
                new Team() { TeamId="BAN", TeamName = "Bangladesh" , TestStatsDetails= new TestStats(){MatchesPlayed=95, MatchesWon=8}, OdiStatsDetails = new OdiStats(){MatchesPlayed=321, MatchesWon=101}} ,
                new Team() { TeamId="IRE", TeamName = "Ireland" , TestStatsDetails= new TestStats(){MatchesPlayed=0, MatchesWon=0}, OdiStatsDetails = new OdiStats(){MatchesPlayed=110, MatchesWon=47}} ,
                new Team() { TeamId="KEN", TeamName = "Kenya" , TestStatsDetails= new TestStats(){MatchesPlayed=0, MatchesWon=0}, OdiStatsDetails = new OdiStats(){MatchesPlayed=154, MatchesWon=42}} ,
                new Team() { TeamId="AFG", TeamName = "Afghanistan" , TestStatsDetails= new TestStats(){MatchesPlayed=0, MatchesWon=0}, OdiStatsDetails = new OdiStats(){MatchesPlayed=70, MatchesWon=35}} ,

            };
            return TeamDetails;
        }

    }
}