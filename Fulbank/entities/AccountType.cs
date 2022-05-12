namespace Fulbank.entities;

public class AccountType
{
    #region Attributes
        private int _id;
        private string _name;
        private string _description;
        private double _interest;
        private double _ceil;
    #endregion
    
    #region Constructor
        public AccountType(int id, string name, string description, double interest, double ceil)
        {
            this.setId(id);
            this.setName(name);
            this.setDescription(description);
            this.setInterest(interest);
            this.setCeil(ceil);
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
        public string getDescription()
        {
            return this._description;
        }
        public double getInterest()
        {
            return this._interest;
        }
        public double getCeil()
        {
            return this._ceil;
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
        public void setDescription(string description)
        {
            this._description = description;
        }
        public void setInterest(double interest)
        {
            this._interest = interest;
        }
        public void setCeil(double ceil)
        {
            this._ceil = ceil;
        }
    #endregion
}