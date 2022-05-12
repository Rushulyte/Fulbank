namespace Fulbank.entities;

public class BankAccount : MoneyInterface
{
    #region Attributes
        private string _iban;
    #endregion
    
    #region Constructor
        public BankAccount(int id, double balance, DateTime createdDate, string iban) : base(id, balance, createdDate)
        {
            this.setIban(iban);
        }
    #endregion
    
    #region Getters
        public string getIban()
        {
            return this._iban;
        }
    #endregion
    
    #region Setters
        public void setIban(string iban)
        {
            this._iban = iban;
        }
    #endregion
}