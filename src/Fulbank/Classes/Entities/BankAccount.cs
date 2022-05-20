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
            SetIban(iban);
            SetAccountType(accountType);
            _operations = new Collection<Operation>();
            _conversions = new Collection<Conversion>();
        }
    #endregion
    
    #region Getters
        public string GetIban()
        {
            return _iban;
        }
        public AccountType GetAccountType()
        {
            return _accountType;
        }
        public Collection<Operation> GetOperations()
        {
            return _operations;
        }
        public Collection<Conversion> GetConversions()
        {
            return _conversions;
        }
    #endregion
    
    #region Setters
        public void SetIban(string iban)
        {
            _iban = iban;
        }
        public void SetAccountType(AccountType accountType)
        {
            _accountType = accountType;
        }
    #endregion
    
    #region Fonctions
        // Operations
        public void LinkOperation(Operation operation)
        {
            _operations.Add(operation);
        }
        public void UnlinkOperation(Operation operation)
        {
            _operations.Remove(operation);
        }
        
        // Conversions
        public void LinkConversion(Conversion conversion)
        {
            _conversions.Add(conversion);
        }
        public void UnlinkConversion(Conversion conversion)
        {
            _conversions.Remove(conversion);
        }
    #endregion
}