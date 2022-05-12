namespace Fulbank.entities;

public class ExternalOperation : Operation
{
    #region Attributes
        private string _targetRib;
    #endregion

    #region Constructor
        public ExternalOperation(int id, double amount, DateTime createdDate, string targetRib) : base(id, amount, createdDate)
        {
            this.setTargetRib(targetRib);
        }
    #endregion
    
    #region Getters
        public string getTargetRib()
        {
            return this._targetRib;
        }
    #endregion
    
    #region Setters
        public void setTargetRib(string targetRib)
        {
            this._targetRib = targetRib;
        }
    #endregion
}