using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank.Classes;

public class Database
{
        #region Attributes
            private string _db;
            private string _user;
            private string _password;
            private string _host;
            private MySqlConnection _conn;
        #endregion

        #region Getters
            public string GetName()
            {
                return _db;
            }
            public string GetUser()
            {
                return _user;
            }
            public string GetPassword()
            {
                return _password;
            }
            public string GetHost()
            {
                return _host;
            }
            public MySqlConnection GetConnection()
            {
                return _conn;
            }
        #endregion
        
        #region Setters
            public void SetName(string name)
            {
                _db = name;
            }
            public void SetUser(string user)
            {
                _user = user;
            }
            public void SetPassword(string password)
            {
                _password = password;
            }
            public void SetHost(string host)
            {
                _host = host;
            }
        #endregion
        
        #region Connection
            public void CreateConnection()
            {
                _conn = new MySqlConnection($"server={_host};database={_db};uid={_user};password={_password};SSL MODE='None'");
            }
            private void OpenConnection(MySqlConnection sql)
            {
                sql.Open();
            }
            private void CloseConnection(MySqlConnection sql)
            {
                sql.Close();
            }
            public bool TestConnection(MySqlConnection sql)
            {
                try
                {
                    OpenConnection(sql);
                    CloseConnection(sql);
                    MessageBox.Show(@"Database connected");
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show($@"#ERROR# Can't connect to the database : {e}");
                    return false;
                }
            }
        #endregion

        #region Fonctions
            private static string ToStr(IReadOnlyList<string> list)
            {
                StringBuilder result = new StringBuilder(list[0]);
                for (int i = 1 ; i < list.Count; i++ )
                {
                    result.Append($",{list[i]}");
                }
                return result.ToString();
            }
            private static IReadOnlyList<string> ToList(string str)
            {
                return str.Split(',');
            }
            private static string ToBind(IReadOnlyCollection<string> list)
            {
                StringBuilder result = new StringBuilder("@val1"); 
                for (int i = 1 ; i < list.Count; i++ )
                {
                    result.Append($",@val{(i + 1)}");
                }
                return result.ToString();
            }
            private static string ToEquals(Collection<string> properties, IReadOnlyList<string> values)
            {
                StringBuilder result = new StringBuilder($"{properties[0]}={values[0]}"); 
                if (properties.Count == values.Count)
                {
                    for (int i = 1 ; i < properties.Count ; i++)
                    {
                        result.Append($",{properties[i]}={values[i]}");
                    }
                }
                return result.ToString();
            }
        #endregion
        
        #region Queries
            private void Execute(MySqlConnection sql, MySqlCommand query)
            {
                OpenConnection(sql);
                query.Prepare();
                query.ExecuteReader();
                CloseConnection(sql);
            }
            private void ExecuteValues(MySqlConnection sql, MySqlCommand query, IReadOnlyList<string> bindValues, IReadOnlyList<string> values)
            {
                for (int i = 0 ; i < bindValues.Count ; i++)
                {
                    query.Parameters.AddWithValue(bindValues[i],values[i]);
                }
                Execute(sql, query);
            }
            public void Insert(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values)
            {
                string bindValues = ToBind(values);
                MySqlCommand query = new MySqlCommand($"INSERT INTO {table}({ToStr(properties)}) VALUES ({bindValues});", sql);
                ExecuteValues(sql, query, ToList(bindValues), values);
            }

            public void Update(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values, string conditions)
            {
                string command = $"UPDATE {table} SET {ToEquals(properties, values)} WHERE {conditions};";
                MySqlCommand query = new MySqlCommand(command, sql);
                Execute(sql, query);
            }

            public void Delete(MySqlConnection sql, string table, string conditions = "1")
            {
                string command = $"DELETE FROM {table} WHERE {conditions};";
                MySqlCommand query = new MySqlCommand(command, sql);
                Execute(sql, query);
            }
        #endregion
}