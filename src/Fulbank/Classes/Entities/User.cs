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
            setId(id);
            setFirstname(firstname);
            setLastname(lastname);
            setEmail(email);
            setAuthenticationString(authenticationString);
            setPhone(phone);
            setAddress(address);
            setSalt(salt);
            setCreatedDate(createdDate);
            setType(type);
            _accounts = new Collection<MoneyInterface>();
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return _id;
        }
        public string getFirstname()
        {
            return _firstname;
        }
        public string getLastname()
        {
            return _lastname;
        }
        public string getEmail()
        {
            return _email;
        }
        public string getAuthenticationString()
        {
            return _authenticationString;
        }
        public string getPhone()
        {
            return _phone;
        }
        public string getAddress()
        {
            return _address;
        }
        public string getSalt()
        {
            return _salt;
        }
        public DateTime getCreatedDate()
        {
            return _createdDate;
        }
        public UserType getType()
        {
            return _type;
        }
        public Collection<MoneyInterface> getAccounts()
        {
            return _accounts;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            _id = id;
        }
        public void setFirstname(string firstname)
        {
            _firstname = firstname;
        }
        public void setLastname(string lastname)
        {
            _lastname = lastname;
        }
        public void setEmail(string email)
        {
            _email = email;
        }
        public void setAuthenticationString(string auth_string)
        {
            _authenticationString = auth_string;
        }
        public void setPhone(string phone)
        {
            _phone = phone;
        }
        public void setAddress(string address)
        {
            _address = address;
        }
        public void setSalt(string salt)
        {
            _salt = salt;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            _createdDate = createdDate;
        }
        public void setType(UserType type)
        {
            _type = type;
        }
    #endregion
    
    #region Fonctions
        public void linkAccount(MoneyInterface account)
        {
            _accounts.Add(account);
        }
        public void unlinkAccount(MoneyInterface account)
        {
            _accounts.Remove(account);
        }
    #endregion
}