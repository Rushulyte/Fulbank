using System.Collections.ObjectModel;

namespace Fulbank.entities;

public class BankAccount : MoneyInterface
{
    #region Attributes
        private string _iban;
        private AccountType _accountType;
        private Collection<Operation> _operations;
        private Collection<Conversion> _conversions;
    #endregion
    
    #region Constructor
        public BankAccount(int id, double balance, DateTime createdDate, string iban, AccountType accountType, User user) : base(id, balance, createdDate, user)
        {
            this.setIban(iban);
            this.setAccountType(accountType);
        }
    #endregion
    
    #region Getters
        public string getIban()
        {
            return this._iban;
        }
        public AccountType getAccountType()
        {
            return this._accountType;
        }
        public Collection<Operation> getOperations()
        {
            return this._operations;
        }
        public Collection<Conversion> getConversions()
        {
            return this._conversions;
        }
    #endregion
    
    #region Setters
        public void setIban(string iban)
        {
            this._iban = iban;
        }
        public void setAccountType(AccountType accountType)
        {
            this._accountType = accountType;
        }
    #endregion
    
    #region Fonctions
        // Operations
        public void addOperation(Operation operation)
        {
            this._operations.Add(operation);
        }
        public void removeOperation(Operation operation)
        {
            this._operations.Remove(operation);
        }
        
        // Conversions
        public void addConversion(Conversion conversion)
        {
            this._conversions.Add(conversion);
        }
        public void removeConversion(Conversion conversion)
        {
            this._conversions.Remove(conversion);
        }
    #endregion
}