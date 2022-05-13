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
            setId(id);
            setName(name);
            setRole(role);
            _users = new Collection<User>();
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
        public string getRole()
        {
            return _role;
        }
        public Collection<User> getUsers()
        {
            return _users;
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
        public void setRole(string role)
        {
            _role = role;
        }
    #endregion

    #region Fonctions
        public void linkUser(User user)
        {
            _users.Add(user);
        }
        public void unlinkUser(User user)
        {
            _users.Remove(user);
        }
    #endregion
}