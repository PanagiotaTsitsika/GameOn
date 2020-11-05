using System;
using System.Collections.Generic;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class ParticipationRepository : IParticipationRepository
    {
        private readonly ApplicationDbContext _context;
        public ParticipationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Participation GetParticipation(int tournamentId, string userId)
        {
            return _context.Participations
                    .SingleOrDefault(p => p.TournamentId == tournamentId && p.GamerId == userId);
        }
        public IEnumerable<Participation> GetFutureParticipations(string userId)
        {
            return _context.Participations
                .Where(p => p.GamerId == userId && p.Tournament.DateTime > DateTime.Now)
                .ToList();

        }
        public void Add(Participation participation)
        {
            _context.Participations.Add(participation);
        }

        public void Remove(Participation participation)
        {
            _context.Participations.Remove(participation);
        }
    }
}