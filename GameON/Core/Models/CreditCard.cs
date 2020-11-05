using System;
using System.ComponentModel.DataAnnotations;

namespace GameON.Core.Models
{
    public class CreditCard
    {
        [Key]
        public string CreditCardUserId { get; private set; }
        public ApplicationUser User { get; set; }
        public string CardNumber { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public short CCV { get; private set; }
        private decimal Deposit { get; set; }

        private readonly Random random = new Random();

        private CreditCard() { }

        public CreditCard(string userId, string cardNumber, DateTime expireDate, short ccv)
        {
            CreditCardUserId = userId;
            CardNumber = cardNumber;
            ExpireDate = expireDate;
            CCV = ccv;
            Deposit = GetRandomDeposit();
        }
        public void PaySubsciption(decimal fee)
        {
            this.Deposit -= fee;
            this.User.Subscribe();
        }

        private decimal GetRandomDeposit()
        {
            return random.Next(100, 1000);
        }

    }
}