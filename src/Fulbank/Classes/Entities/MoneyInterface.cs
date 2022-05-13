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
            setId(id);
            setBalance(balance);
            setCreatedDate(createdDate);
            setUser(user);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return _id;
        }
        public double getBalance()
        {
            return _balance;
        }
        public DateTime getCreatedDate()
        {
            return _createdDate;
        }
        public User getUser()
        {
            return _user;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            _id = id;
        }
        public void setBalance(double balance)
        {
            _balance = balance;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void setUser(User user)
        {
            _user = user;
        }
    #endregion
}