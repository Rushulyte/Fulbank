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
            setId(id);
            setName(name);
            _wallets = new Collection<Wallet>();
        }
    #endregion
    
    #region Getters
        public int getId()
        {
            return _id;
        }
        public string getName()
        {
            return _name;
        }
        public Collection<Wallet> getWallets()
        {
            return _wallets;
        }
    #endregion
    
    #region Setters
        public void setId(int id)
        {
            _id = id;
        }
        public void setName(string name)
        {
            _name = name;
        }
    #endregion
    
    #region Fonctions
        public void linkWallet(Wallet wallet)
        {
            _wallets.Add(wallet);
        }
        public void unlinkWallet(Wallet wallet)
        {
            _wallets.Remove(wallet);
        }
    #endregion
}