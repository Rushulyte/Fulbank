using System;
using System.Dynamic;

namespace Fulbank.entities;

public abstract class MoneyInterface
{
    #region Attributes
        private int _id;
        private double _balance;
        private DateTime _createdDate;
    #endregion
    
    #region Constructor
        protected MoneyInterface(int id, double balance, DateTime createdDate)
        {
            this.setId(id);
            this.setBalance(balance);
            this.setCreatedDate(createdDate);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return this._id;
        }
        public double getBalance()
        {
            return this._balance;
        }
        public DateTime getCreatedDate()
        {
            return _createdDate;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            this._id = id;
        }
        public void setBalance(double balance)
        {
            this._balance = balance;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            this._createdDate = createdDate;
        }
    #endregion
}