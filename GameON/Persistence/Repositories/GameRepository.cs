using System.Collections.Generic;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;
        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Game> GetAllGames()
        {
            return _context.Games.ToList();
        }
    }
}