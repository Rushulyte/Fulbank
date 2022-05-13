using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank.Classes
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
                _db = "fulbank";
                _user = "root";
                _psswd = "''";
                _host = "localhost";
                _data = "server=" + _host + ";database=" + _db + ";uid=" + _user + ";password=" + _psswd + ";SSL MODE='None'";
            }
        #endregion
        
        #region Getters
            public MySqlConnection getConnection()
            {
                return _conn;
            }
        #endregion
        
        #region Fonctions
            // Connection
            public void createConnection()
            {
                try
                {
                    _conn = new MySqlConnection(_data);
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("#ERROR# Can't connect to the database : " + e);
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
                    MessageBox.Show("#ERROR# Can't open the database : " + e);
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
                    MessageBox.Show("#ERROR# Can't close the database : " + e);
                }
            }

            // Fonctions
            private string ToStr(Collection<string> list)
            {
                string result = list[0];
                for (int i = 1 ; i < list.Count; i++ )
                {
                    result += "," + list[i];
                }
                return result;
            }
            public string[] ToList(string str)
            {
                Collection<string> result = new Collection<string>();
                return str.Split(',');
            }
            private bool verifyQuery(string query)
            {
                return true;
            }

            // Queries
            public void insert(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values)
            {
                var query = new MySqlCommand();
                query.Connection = sql;

                // query.CommandText = "INSERT INTO " + table + ToStr(properties) + " VALUES" + ToStr(values);
                query.CommandText = "INSERT INTO " + table + "(" + properties[0] + ", " + properties[1] + ", " + properties[2] + ") VALUES(" + values[0] + ", " + values[1] + ", " + values[2] + ")";
                
                if (verifyQuery(query.ToString()))
                {
                    query.ExecuteNonQuery();
                }
            }
        #endregion
    }
}