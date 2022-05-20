using System.Collections.ObjectModel;

namespace Fulbank.Classes.Entities;

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
            SetId(id);
            SetName(name);
            _wallets = new Collection<Wallet>();
        }
    #endregion
    
    #region Getters
        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public Collection<Wallet> GetWallets()
        {
            return _wallets;
        }
    #endregion
    
    #region Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
    #endregion
    
    #region Fonctions
        public void LinkWallet(Wallet wallet)
        {
            _wallets.Add(wallet);
        }
        public void UnlinkWallet(Wallet wallet)
        {
            _wallets.Remove(wallet);
        }
    #endregion
}