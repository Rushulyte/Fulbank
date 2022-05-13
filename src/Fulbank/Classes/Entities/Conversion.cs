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
            setId(id);
            setAmount(amount);
            setCreatedDate(createdDate);
            setAccount(account);
            setWallet(wallet);
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
        public Wallet getWallet()
        {
            return _wallet;
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
        public void setWallet(Wallet wallet)
        {
            _wallet = wallet;
        }
    #endregion
}