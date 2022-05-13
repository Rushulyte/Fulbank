using System.Collections.ObjectModel;

namespace Fulbank.entities;

public class UserType : Meta
{
    #region Attributes
        private int _id;
        private string _name;
        private string _role;
        private Collection<User> _users;
    #endregion
    
    #region Constructor
        public UserType(int id, string name, string role)
        {
            this.setId(id);
            this.setName(name);
            this.setRole(role);
            this._users = new Collection<User>();
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
        public string getRole()
        {
            return this._role;
        }
        public Collection<User> getUsers()
        {
            return this._users;
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
        public void setRole(string role)
        {
            this._role = role;
        }
    #endregion

    #region Fonctions
        public void addUser(User user)
        {
            this._users.Add(user);
        }
        public void removeUser(User user)
        {
            this._users.Remove(user);
        }
    #endregion
}