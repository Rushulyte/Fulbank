using System.Collections.ObjectModel;

namespace Fulbank.Classes.Entities;

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
            SetId(id);
            SetName(name);
            SetRole(role);
            _users = new Collection<User>();
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
        public string GetRole()
        {
            return _role;
        }
        public Collection<User> GetUsers()
        {
            return _users;
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
        public void SetRole(string role)
        {
            _role = role;
        }
    #endregion

    #region Fonctions
        public void LinkUser(User user)
        {
            _users.Add(user);
        }
        public void UnlinkUser(User user)
        {
            _users.Remove(user);
        }
    #endregion
}