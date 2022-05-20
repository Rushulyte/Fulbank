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
            SetTargetRib(targetRib);
        }
    #endregion
    
    #region Getters
        public string GetTargetRib()
        {
            return _targetRib;
        }
    #endregion
    
    #region Setters
        public void SetTargetRib(string targetRib)
        {
            _targetRib = targetRib;
        }
    #endregion
}