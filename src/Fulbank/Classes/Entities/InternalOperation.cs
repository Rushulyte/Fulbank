using System;

namespace Fulbank.entities;

public class InternalOperation : Operation, Meta
{
    #region Attributes
        private BankAccount _target;
    #endregion
    
    #region Constructor
        public InternalOperation(int id, double amount, DateTime createdDate, BankAccount origin, BankAccount target) : base(id, amount, createdDate, origin)
        {
            this.setTarget(target);
        }
    #endregion
    
    #region Getters
        public BankAccount getTarget()
        {
            return this._target;
        }
    #endregion
    
    #region Setters
        public void setTarget(BankAccount target)
        {
            this._target = target;
        }
    #endregion
}