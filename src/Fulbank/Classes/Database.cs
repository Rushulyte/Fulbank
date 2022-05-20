using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank.entities
{
    public class Database
    {
        #region Attributes
            private string _db;
            private string _user;
            private string _psswd;
            private string _host;
            private string _data;
            private MySqlConnection _conn;
        #endregion
        
        #region Constructor
            public Database()
            {
                this._db = "fulbank";
                this._user = "root";
                this._psswd = "''";
                this._host = "localhost";
                this._data = "server=" + this._host + ";database=" + this._db + ";uid=" + this._user + ";password=" + this._psswd + ";SSL MODE='None'";
            }
        #endregion
        
        #region Getters
            public MySqlConnection getConnection()
            {
                return this._conn;
            }
        #endregion
        
        #region Fonctions
            public void createConnection()
            {
                try
                {
                    this._conn = new MySqlConnection(this._data);
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("#ERROR# Can't connect to the database : " + e.ToString());
                }
            }
            
            public void openConnection(MySqlConnection sql)
            {
                try
                {
                    sql.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("#ERROR# Can't open the database : " + e.ToString());
                }
            }
            
            
            public void closeConnection(MySqlConnection sql)
            {
                try
                {
                    sql.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("#ERROR# Can't close the database : " + e.ToString());
                }
            }
            
        #endregion
    }
}