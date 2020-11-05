using System.Collections.Generic;
using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();
    }
}
