using System;

namespace Fulbank.Classes.Entities;

public abstract class Operation
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
            setId(id);
            setAmount(amount);
            setCreatedDate(createdDate);
            setAccount(account);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return _id;
        }
        public double getAmount()
        {
            return _amount;
        }
        public DateTime getCreatedDate()
        {
            return _createdDate;
        }
        public BankAccount getAccount()
        {
            return _account;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            _id = id;
        }
        public void setAmount(double amount)
        {
            _amount = amount;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void setAccount(BankAccount account)
        {
            _account = account;
        }
    #endregion
}