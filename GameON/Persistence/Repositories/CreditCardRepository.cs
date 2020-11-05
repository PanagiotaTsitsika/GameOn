using System.Data.Entity;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly ApplicationDbContext _context;
        public CreditCardRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(CreditCard card)
        {
            _context.CreditCards.Add(card);
        }

        public CreditCard GetCreditCard(string userId)
        {
            return _context.CreditCards
                .Include(c => c.User)
                .SingleOrDefault(c => c.CreditCardUserId == userId);
                
        }
    }
}