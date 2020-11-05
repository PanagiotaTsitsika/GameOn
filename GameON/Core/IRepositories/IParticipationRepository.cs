using System.Collections.Generic;
using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface IParticipationRepository
    {
        Participation GetParticipation(int tournamentId, string userId);
        IEnumerable<Participation> GetFutureParticipations(string userId);
        void Add(Participation participation);
        void Remove(Participation participation);
    }
}
