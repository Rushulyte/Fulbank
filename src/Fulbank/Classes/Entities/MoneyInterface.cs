using System;

namespace Fulbank.Classes.Entities;

public abstract class MoneyInterface : Meta
{
    #region Attributes
        private int _id;
        private double _balance;
        private DateTime _createdDate;
        private User _user;
    #endregion
    
    #region Constructor
        public MoneyInterface(int id, double balance, DateTime createdDate, User user)
        {
            this.setId(id);
            this.setBalance(balance);
            this.setCreatedDate(createdDate);
            this.setUser(user);
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
        public User getUser()
        {
            return this._user;
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
        public void setUser(User user)
        {
            this._user = user;
        }
    #endregion
}