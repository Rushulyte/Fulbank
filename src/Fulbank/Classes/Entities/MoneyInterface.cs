using System;

namespace Fulbank.Classes.Entities;

public abstract class MoneyInterface
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
            SetId(id);
            SetBalance(balance);
            SetCreatedDate(createdDate);
            SetUser(user);
        }
    #endregion
    
    #region Getters
        public int GetId()
        {
            return _id;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public DateTime GetCreatedDate()
        {
            return _createdDate;
        }
        public User GetUser()
        {
            return _user;
        }
    #endregion
    
    #region Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetBalance(double balance)
        {
            _balance = balance;
        }
        public void SetCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void SetUser(User user)
        {
            _user = user;
        }
    #endregion
}