using System;

namespace Fulbank.Classes.Entities;

public class ExternalOperation : Operation
{
    #region Attributes
        private string _targetRib;
    #endregion

    #region Constructor
        public ExternalOperation(int id, double amount, DateTime createdDate, string targetRib, BankAccount origin) : base(id, amount, createdDate, origin)
        {
            setTargetRib(targetRib);
        }
    #endregion
    
    #region Getters
        public string getTargetRib()
        {
            return _targetRib;
        }
    #endregion
    
    #region Setters
        public void setTargetRib(string targetRib)
        {
            _targetRib = targetRib;
        }
    #endregion
}