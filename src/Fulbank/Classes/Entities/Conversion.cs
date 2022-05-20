using System;

namespace Fulbank.Classes.Entities;

public class Conversion : Meta
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
            SetId(id);
            SetAmount(amount);
            SetCreatedDate(createdDate);
            SetAccount(account);
            SetWallet(wallet);
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
        public Wallet GetWallet()
        {
            return _wallet;
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
        public void SetWallet(Wallet wallet)
        {
            _wallet = wallet;
        }
    #endregion
}