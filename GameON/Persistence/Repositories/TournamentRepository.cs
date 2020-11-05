using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class TournamentRepository :ITournamentRepository
    {
        public ApplicationDbContext _context;
        public TournamentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Tournament> GetTournamentsGamerParticipating(string userId)
        {
            return _context.Participations
                .Where(p => p.GamerId == userId)
                .Select(p => p.Tournament)
                .Include(t => t.Host)
                .Include(t => t.Game).ToList();
        }
        public Tournament GetTournament(int id)
        {
            return _context.Tournaments
                .Include(t => t.Host)
                .Include(t => t.Game)
                .SingleOrDefault(t => t.Id == id);
        }
        public IEnumerable<Tournament> GetUpcomingTournaments()
        {
            return _context.Tournaments
                .Include(t => t.Host)
                .Include(t => t.Game)
                .Where(t => t.DateTime > DateTime.Now && !t.IsCancelled);
        }
        public IEnumerable<Tournament> GetUpcomingTournamentsByHost(string userId)
        {
            return _context.Tournaments
                .Where(t => t.HostId == userId && t.DateTime > DateTime.Now && !t.IsCancelled)
                .Include(t => t.Game)
                .ToList();
        }
        public Tournament GetTournamentWithParticipants(int id)
        {
            return _context.Tournaments
                .Include(t => t.Participations.Select(p => p.Gamer))
                .Single(t => t.Id == id);
        }

        public void Add(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
        }
    }
}