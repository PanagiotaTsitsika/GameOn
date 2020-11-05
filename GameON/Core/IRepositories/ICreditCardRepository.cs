using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface ICreditCardRepository
    {
        void Add(CreditCard card);
        CreditCard GetCreditCard(string userId);
    }
}