using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        // Prize 생성
        PrizeModel CreatePrize(PrizeModel model);
        // Person 생성
        PersonModel CreatePerson(PersonModel model);
        // Team 생성
        TeamModel CreateTeam(TeamModel model);
        // Tournament 생성
        void CreateTournament(TournamentModel model);
        // Team List 모두 가져옴
        List<TeamModel> GetTeam_All();
        // Person List 모두 가져옴
        List<PersonModel> GetPerson_All();

    }
}
