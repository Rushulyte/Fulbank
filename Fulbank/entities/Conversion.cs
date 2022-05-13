using System;

namespace Fulbank.entities;

public class Conversion
{
    #region Attributes
        private int _id;
        private double _amount;
        private DateTime _createdDate;
        private BankAccount _account;
        private Wallet _wallet;
    #endregion
    
    #region Constructor
        public Conversion(int id, double amount, DateTime createdDate, BankAccount account, Wallet wallet)
        {
            this.setId(id);
            this.setAmount(amount);
            this.setCreatedDate(createdDate);
            this.setAccount(account);
            this.setWallet(wallet);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return this._id;
        }
        public double getAmount()
        {
            return this._amount;
        }
        public DateTime getCreatedDate()
        {
            return this._createdDate;
        }
        public BankAccount getAccount()
        {
            return this._account;
        }
        public Wallet getWallet()
        {
            return this._wallet;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            this._id = id;
        }
        public void setAmount(double amount)
        {
            this._amount = amount;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            this._createdDate = createdDate;
        }
        public void setAccount(BankAccount account)
        {
            this._account = account;
        }
        public void setWallet(Wallet wallet)
        {
            this._wallet = wallet;
        }
    #endregion
}