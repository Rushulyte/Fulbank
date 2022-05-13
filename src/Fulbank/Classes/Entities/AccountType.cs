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
            setId(id);
            setName(name);
            setDescription(description);
            setInterest(interest);
            setCeil(ceil);
            _accounts = new Collection<BankAccount>();
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return _id;
        }
        public string getName()
        {
            return _name;
        }
        public string getDescription()
        {
            return _description;
        }
        public double getInterest()
        {
            return _interest;
        }
        public double getCeil()
        {
            return _ceil;
        }
        public Collection<BankAccount> getAccounts()
        {
            return _accounts;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            _id = id;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public void setDescription(string description)
        {
            _description = description;
        }
        public void setInterest(double interest)
        {
            _interest = interest;
        }
        public void setCeil(double ceil)
        {
            _ceil = ceil;
        }
    #endregion
    
    #region Fonctions
        public void linkAccount(BankAccount account)
        {
            _accounts.Add(account);
        }
        public void unlinkAccount(BankAccount account)
        {
            _accounts.Remove(account);
        }
    #endregion
}