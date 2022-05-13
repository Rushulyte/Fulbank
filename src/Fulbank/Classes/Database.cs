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
        
        #region Connection
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