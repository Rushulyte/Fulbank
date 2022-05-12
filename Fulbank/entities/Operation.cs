using System;

namespace Fulbank.entities;

public abstract class Operation
{
    #region Attributes
        private int _id;
        private double _amount;
        private DateTime _createdDate;
    #endregion
    
    #region Constructor
        protected Operation(int id, double amount, DateTime createdDate)
        {
            this.setId(id);
            this.setAmount(amount);
            this.setCreatedDate(createdDate);
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return this._id;
        }
        public double getAmount()
        {
            return this._amount;
        }
        public DateTime getCreatedDate()
        {
            return _createdDate;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            this._id = id;
        }
        public void setAmount(double amount)
        {
            this._amount = amount;
        }
        public void setCreatedDate(DateTime createdDate)
        {
            this._createdDate = createdDate;
        }
    #endregion
}