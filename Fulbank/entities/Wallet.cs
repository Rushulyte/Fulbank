namespace Fulbank.entities;

public class Wallet : MoneyInterface
{
    #region Constructor
        public Wallet(int id, double balance, DateTime createdDate) : base(id, balance, createdDate) {}
    #endregion
}