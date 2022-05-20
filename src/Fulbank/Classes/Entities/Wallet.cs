using System;

namespace Fulbank.Classes.Entities;

public class Wallet : MoneyInterface
{
    #region Attributes
        private CryptoCurrency _crypto;
    #endregion
    
    #region Constructor
        public Wallet(int id, double balance, DateTime createdDate, User user, CryptoCurrency crypto) : base(id, balance, createdDate, user)
        {
            SetCrypto(crypto);
        }
    #endregion
    
    #region Getters
        public CryptoCurrency GetCrypto()
        {
            return _crypto;
        }
    #endregion
    
    #region Setters
        public void SetCrypto(CryptoCurrency crypto)
        {
            _crypto = crypto;
        }
    #endregion
}