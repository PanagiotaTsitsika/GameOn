using System.Collections.Generic;
using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface ITournamentRepository
    {
        IEnumerable<Tournament> GetTournamentsGamerParticipating(string userId);
        Tournament GetTournament(int id);
        IEnumerable<Tournament> GetUpcomingTournaments();
        IEnumerable<Tournament> GetUpcomingTournamentsByHost(string userId);
        Tournament GetTournamentWithParticipants(int id);
        void Add(Tournament tournament);





    }
}
