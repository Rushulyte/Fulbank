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
    public static void OpenConnection(MySqlConnection sql)
    {
        sql.Open();
    }
    public static void CloseConnection(MySqlConnection sql)
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
    private static string[] ToList(string str)
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
        #endregion
        
        #region Queries
    private static void Execute(MySqlCommand command, IReadOnlyList<string> bindValues, IReadOnlyList<string> values)
    {
        for (int i = 0 ; i < bindValues.Count ; i++)
        {
            command.Parameters.AddWithValue(bindValues[i],values[i]);
        }
        command.Prepare();
        command.ExecuteReader();
    }
            
    public void Insert(MySqlConnection sql, string table, Collection<string> properties, Collection<string> values)
    {
        string bindValues = ToBind(values);
        MySqlCommand query = new MySqlCommand($"INSERT INTO {table} ({ToStr(properties)}) VALUES ({bindValues});", sql);
        Execute(query, ToList(bindValues), values);
    }
        #endregion
}