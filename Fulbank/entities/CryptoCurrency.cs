namespace Fulbank.entities;

public class CryptoCurrency
{
    #region Attributes
        private int _id;
        private string _name;
    #endregion
    
    #region Constructor
        public CryptoCurrency(int id, string name)
        {
            this.setId(id);
            this.setName(name);
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
    #endregion
}