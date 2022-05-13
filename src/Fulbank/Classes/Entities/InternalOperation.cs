using System;

namespace Fulbank.Classes.Entities;

public class InternalOperation : Operation
{
    #region Attributes
        private BankAccount _target;
    #endregion
    
    #region Constructor
        public InternalOperation(int id, double amount, DateTime createdDate, BankAccount origin, BankAccount target) : base(id, amount, createdDate, origin)
        {
            setTarget(target);
        }
    #endregion
    
    #region Getters
        public BankAccount getTarget()
        {
            return _target;
        }
    #endregion
    
    #region Setters
        public void setTarget(BankAccount target)
        {
            _target = target;
        }
    #endregion
}