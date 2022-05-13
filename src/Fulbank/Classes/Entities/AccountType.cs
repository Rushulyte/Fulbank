using System.Collections.ObjectModel;

namespace Fulbank.entities;

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
            this.setId(id);
            this.setName(name);
            this.setDescription(description);
            this.setInterest(interest);
            this.setCeil(ceil);
            this._accounts = new Collection<BankAccount>();
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return this._id;
        }
        public string getName()
        {
            return this._name;
        }
        public string getDescription()
        {
            return this._description;
        }
        public double getInterest()
        {
            return this._interest;
        }
        public double getCeil()
        {
            return this._ceil;
        }
        public Collection<BankAccount> getAccounts()
        {
            return this._accounts;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            this._id = id;
        }
        public void setName(string name)
        {
            this._name = name;
        }
        public void setDescription(string description)
        {
            this._description = description;
        }
        public void setInterest(double interest)
        {
            this._interest = interest;
        }
        public void setCeil(double ceil)
        {
            this._ceil = ceil;
        }
    #endregion
    
    #region Fonctions
        public void linkAccount(BankAccount account)
        {
            this._accounts.Add(account);
        }
        public void unlinkAccount(BankAccount account)
        {
            this._accounts.Remove(account);
        }
    #endregion
}