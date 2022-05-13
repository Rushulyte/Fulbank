using System;

namespace Fulbank.entities;

public abstract class Operation : Meta
{
    #region Attributes
        private int _id;
        private double _amount;
        private DateTime _createdDate;
        private BankAccount _account;
    #endregion
    
    #region Constructor
    protected Operation(int id, double amount, DateTime createdDate, BankAccount account)
        {
            this.setId(id);
            this.setAmount(amount);
            this.setCreatedDate(createdDate);
            this.setAccount(account);
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
            return _createdDate;
        }
        public BankAccount getAccount()
        {
            return this._account;
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
    #endregion
}