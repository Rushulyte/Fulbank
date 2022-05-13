using System;
using System.Collections.ObjectModel;

namespace Fulbank.entities;

public class Wallet : MoneyInterface Meta
{
    #region Attributes
        private CryptoCurrency _crypto;
    #endregion
    
    #region Constructor
        public Wallet(int id, double balance, DateTime createdDate, User user, CryptoCurrency crypto) : base(id, balance, createdDate, user)
        {
            this.setCrypto(crypto);
        }
    #endregion
    
    #region Getters
        public CryptoCurrency getCrypto()
        {
            return this._crypto;
        }
    #endregion
    
    #region Setters
        public void setCrypto(CryptoCurrency crypto)
        {
            this._crypto = crypto;
        }
    #endregion
}