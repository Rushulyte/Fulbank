using System.Collections.ObjectModel;

namespace Fulbank.entities;

public class User
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
            this.setId(id);
            this.setFirstname(firstname);
            this.setLastname(lastname);
            this.setEmail(email);
            this.setAuthenticationString(authenticationString);
            this.setPhone(phone);
            this.setAddress(address);
            this.setSalt(salt);
            this.setCreatedDate(createdDate);
            this.setType(type);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return this._id;
        }
        public string getFirstname()
        {
            return this._firstname;
        }
        public string getLastname()
        {
            return this._lastname;
        }
        public string getEmail()
        {
            return this._email;
        }
        public string getAuthenticationString()
        {
            return this._authenticationString;
        }
        public string getPhone()
        {
            return this._phone;
        }
        public string getAddress()
        {
            return this._address;
        }
        public string getSalt()
        {
            return this._salt;
        }
        public DateTime getCreatedDate()
        {
            return this._createdDate;
        }
        public UserType getType()
        {
            return this._type;
        }
        public Collection<MoneyInterface> getAccounts()
        {
            return this._accounts;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            this._id = id;
        }
        public void setFirstname(string firstname)
        {
            this._firstname = firstname;
        }
        public void setLastname(string lastname)
        {
            this._lastname = lastname;
        }
        public void setEmail(string email)
        {
            this._email = email;
        }
        public void setAuthenticationString(string auth_string)
        {
            this._authenticationString = auth_string;
        }
        public void setPhone(string phone)
        {
            this._phone = phone;
        }
        public void setAddress(string address)
        {
            this._address = address;
        }
        public void setSalt(string salt)
        {
            this._salt = salt;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            this._createdDate = createdDate;
        }
        public void setType(UserType type)
        {
            this._type = type;
        }
    #endregion
    
    #region Fonctions
        public void addAccount(MoneyInterface account)
        {
            this._accounts.Add(account);
        }
        public void removeAccount(MoneyInterface account)
        {
            this._accounts.Remove(account);
        }
    #endregion
}