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
            SetId(id);
            SetAmount(amount);
            SetCreatedDate(createdDate);
            SetAccount(account);
        }
    #endregion
    
    #region Getters
        public int GetId()
        {
            return _id;
        }
        public double GetAmount()
        {
            return _amount;
        }
        public DateTime GetCreatedDate()
        {
            return _createdDate;
        }
        public BankAccount GetAccount()
        {
            return _account;
        }
    #endregion
    
    #region Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetAmount(double amount)
        {
            _amount = amount;
        }
        public void SetCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void SetAccount(BankAccount account)
        {
            _account = account;
        }
    #endregion
}