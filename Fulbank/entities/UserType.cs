namespace Fulbank.entities;

public class UserType
{
    #region Attributes
        private int _id;
        private string _name;
        private string _role;
    #endregion
    
    #region Constructor
        public UserType(int id, string name, string role)
        {
            this.setId(id);
            this.setName(name);
            this.setRole(role);
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
}