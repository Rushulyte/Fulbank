using System;
using System.Collections.ObjectModel;

namespace Fulbank.Classes.Entities;

public class User : Meta
{
    #region Attributes
        private int _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _authenticationString;
        private string _phone;
        private string _address;
        private string _salt;
        private DateTime _createdDate;
        private UserType _type;
        private Collection<MoneyInterface> _accounts;
    #endregion
    
    #region Constructor
        public User(int id, string firstname, string lastname, string email, string authenticationString, string phone,
            string address, string salt, DateTime createdDate, UserType type)
        {
            SetId(id);
            SetFirstname(firstname);
            SetLastname(lastname);
            SetEmail(email);
            SetAuthenticationString(authenticationString);
            SetPhone(phone);
            SetAddress(address);
            SetSalt(salt);
            SetCreatedDate(createdDate);
            SetType(type);
            _accounts = new Collection<MoneyInterface>();
        }
    #endregion
    
    #region Getters
        public int GetId()
        {
            return _id;
        }
        public string GetFirstname()
        {
            return _firstname;
        }
        public string GetLastname()
        {
            return _lastname;
        }
        public string GetEmail()
        {
            return _email;
        }
        public string GetAuthenticationString()
        {
            return _authenticationString;
        }
        public string GetPhone()
        {
            return _phone;
        }
        public string GetAddress()
        {
            return _address;
        }
        public string GetSalt()
        {
            return _salt;
        }
        public DateTime GetCreatedDate()
        {
            return _createdDate;
        }
        public UserType GetUserType()
        {
            return _type;
        }
        public Collection<MoneyInterface> GetAccounts()
        {
            return _accounts;
        }
    #endregion
    
    #region Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetFirstname(string firstname)
        {
            _firstname = firstname;
        }
        public void SetLastname(string lastname)
        {
            _lastname = lastname;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public void SetAuthenticationString(string authString)
        {
            _authenticationString = authString;
        }
        public void SetPhone(string phone)
        {
            _phone = phone;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
        public void SetSalt(string salt)
        {
            _salt = salt;
        }
        public void SetCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void SetType(UserType type)
        {
            _type = type;
        }
    #endregion
    
    #region Fonctions
        public void LinkAccount(MoneyInterface account)
        {
            _accounts.Add(account);
        }
        public void UnlinkAccount(MoneyInterface account)
        {
            _accounts.Remove(account);
        }
    #endregion
}