using System;
using System.Collections.ObjectModel;

namespace Fulbank.Classes.Entities;


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
            setIban(iban);
            setAccountType(accountType);
            _operations = new Collection<Operation>();
            _conversions = new Collection<Conversion>();
        }
    #endregion
    
    #region Getters
        public string getIban()
        {
            return _iban;
        }
        public AccountType getAccountType()
        {
            return _accountType;
        }
        public Collection<Operation> getOperations()
        {
            return _operations;
        }
        public Collection<Conversion> getConversions()
        {
            return _conversions;
        }
    #endregion
    
    #region Setters
        public void setIban(string iban)
        {
            _iban = iban;
        }
        public void setAccountType(AccountType accountType)
        {
            _accountType = accountType;
        }
    #endregion
    
    #region Fonctions
        // Operations
        public void linkOperation(Operation operation)
        {
            _operations.Add(operation);
        }
        public void unlinkOperation(Operation operation)
        {
            _operations.Remove(operation);
        }
        
        // Conversions
        public void linkConversion(Conversion conversion)
        {
            _conversions.Add(conversion);
        }
        public void unlinkConversion(Conversion conversion)
        {
            _conversions.Remove(conversion);
        }
    #endregion
}