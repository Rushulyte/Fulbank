namespace Fulbank.entities;

public class InternalOperation : Operation
{
    #region Constructor
        public InternalOperation(int id, double amount, DateTime createdDate) : base(id, amount, createdDate) {}
    #endregion
}