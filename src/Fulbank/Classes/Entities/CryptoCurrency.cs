using System.Collections.ObjectModel;

namespace Fulbank.entities;

public class CryptoCurrency : Meta
{
    #region Attributes
        private int _id;
        private string _name;
        private Collection<Wallet> _wallets;
    #endregion
    
    #region Constructor
        public CryptoCurrency(int id, string name)
        {
            this.setId(id);
            this.setName(name);
            this._wallets = new Collection<Wallet>();
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
        public Collection<Wallet> getWallets()
        {
            return this._wallets;
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
    
    #region Fonctions
        public void addWallet(Wallet wallet)
        {
            this._wallets.Add(wallet);
        }
        public void removeWallet(Wallet wallet)
        {
            this._wallets.Remove(wallet);
        }
    #endregion
}