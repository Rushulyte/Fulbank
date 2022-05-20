using System.Collections.ObjectModel;

namespace Fulbank.Classes.Entities;

public class AccountType : Meta
{
    #region Attributes
        private int _id;
        private string _name;
        private string _description;
        private double _interest;
        private double _ceil;
        private Collection<BankAccount> _accounts;
    #endregion
    
    #region Constructor
        public AccountType(int id, string name, string description, double interest, double ceil)
        {
            SetId(id);
            SetName(name);
            SetDescription(description);
            SetInterest(interest);
            SetCeil(ceil);
            _accounts = new Collection<BankAccount>();
        }
    #endregion
    
    #region Getters
        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public double GetInterest()
        {
            return _interest;
        }
        public double GetCeil()
        {
            return _ceil;
        }
        public Collection<BankAccount> GetAccounts()
        {
            return _accounts;
        }
    #endregion
    
    #region Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public void SetInterest(double interest)
        {
            _interest = interest;
        }
        public void SetCeil(double ceil)
        {
            _ceil = ceil;
        }
    #endregion
    
    #region Fonctions
        public void LinkAccount(BankAccount account)
        {
            _accounts.Add(account);
        }
        public void UnlinkAccount(BankAccount account)
        {
            _accounts.Remove(account);
        }
    #endregion
}