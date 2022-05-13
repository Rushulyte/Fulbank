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
            // Connection
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

            // Fonctions
            private string ToStr(Collection<string> list)
            {
                // TODO
            }
            private Collection<string> ToList(string str)
            {
                // TODO
            }
            private void verifyQuery(string query)
            {
                // TODO
            }

            // Queries
            public void insert(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values)
            {
                var query = new MySqlCommand();
                query.Connection = sql;

                // query.CommandText = "INSERT INTO " + table + ToStr(properties) + " VALUES" + ToStr(values);
                query.CommandText = "INSERT INTO " + table + "(" + properties[0] + ", " + properties[1] + ", " + properties[2] + ") VALUES(" + values[0] + ", " + values[1] + ", " + values[2] + ")";
                
                if verifyQuery(query)
                {
                    query.ExecuteNonQuery();
                }
            }
        #endregion
    }
}