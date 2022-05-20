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
            private MySqlConnection _conn;
        #endregion

        #region Getters
            public string getName()
            {
                return _db;
            }
            public string getUser()
            {
                return _user;
            }
            public string getPassword()
            {
                return _psswd;
            }
            public string getHost()
            {
                return _host;
            }
            public MySqlConnection getConnection()
            {
                return _conn;
            }
        #endregion
        
        #region Setters
            public void setName(string name)
            {
                _db = name;
            }
            public void setUser(string user)
            {
                _user = user;
            }
            public void setPassword(string password)
            {
                _psswd = password;
            }
            public void setHost(string host)
            {
                _host = host;
            }
        #endregion
        
        #region Connection
            public void createConnection()
            {
                _conn = new MySqlConnection("server=" + _host + ";database=" + _db + ";uid=" + _user + ";password=" + _psswd + ";SSL MODE='None'");
            }
            public void openConnection(MySqlConnection sql)
            {
                sql.Open();
            }
            public void closeConnection(MySqlConnection sql)
            {
                sql.Close();
            }
            public bool testConnection(MySqlConnection sql)
            {
                try
                {
                    openConnection(sql);
                    closeConnection(sql);
                    MessageBox.Show("Database connected");
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show("#ERROR# Can't connect to the database : " + e);
                    return false;
                }
            }
        #endregion

        #region Fonctions
            private string ToStr(Collection<string> list)
            {
                string result = list[0];
                for (int i = 1 ; i < list.Count; i++ )
                {
                    result += "," + list[i];
                }
                return result;
            }
            private string[] ToList(string str)
            {
                Collection<string> result = new Collection<string>();
                return str.Split(',');
            }
            private string ToBind(Collection<string> list)
            {
                string result = "@val1";
                for (int i = 1 ; i < list.Count; i++ )
                {
                    result += "," + "@val" + (i + 1);
                }
                return result;
            }
        #endregion
        
        #region Queries
            private void execute(MySqlCommand command, string[] bindvalues, Collection<string> values)
            {
                for (int i = 0 ; i < bindvalues.Length ; i++)
                {
                    command.Parameters.AddWithValue(bindvalues[i],values[i]);
                }
                command.Prepare();
                command.ExecuteReader();
            }
            
            public void insert(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values)
            {
                string bindValues = ToBind(values);
                MySqlCommand query = new MySqlCommand("INSERT INTO " + table + " (" + ToStr(properties) + ") VALUES" + " (" + bindValues + ");", sql);
                execute(query, ToList(bindValues), values);
            }
        #endregion
    }
}