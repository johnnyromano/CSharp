using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// namespaces to enable database access
using System.Data.OleDb;
using System.Net;
using System.Data;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.5
// name:   clsDataLayer.cs
// desc:   DataLayer for Payroll System

/// <summary>
/// Summary description for clsDataLayer
/// Open connections to (UserActivity, Personnel) datasources
/// allows for CREATE / READ / UPDATE operations against datasources
/// Retrieves IPv4 addresses
/// </summary>

public class clsDataLayer
{
    public clsDataLayer()
    {
    }

    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // new dsUserActivity() Object
        // set new dbConnection as sqlConn
        // sqlDA represents dataset from tblUserActivity sorted by most recent activity first
        // refresh row to db
        // return dsUserActivity() object
        dsUserActivity DS = new dsUserActivity();
        OleDbConnection sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        OleDbDataAdapter sqlDA = new OleDbDataAdapter("SELECT * FROM tblUserActivity ORDER BY ActivityID DESC", sqlConn);
        sqlDA.Fill(DS.tblUserActivity);       
        return DS;
    }

    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // set new dbConnection
        // and opens a connection
        // represent an SQL statement or stored procedure to execute against a data source.
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        conn.Open(); 
        OleDbCommand command = conn.CreateCommand();

        // paramaterize SQL string
        // set value indicating how property should be interpreted
        // set SQL statement
        // execute SQL against the connection and returns number of rows affected
        // close connection
        string strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" + GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }


    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // new dsUser() Object
        // set new dbConnection as sqlConn
        // sqlDA represents dataset from tblUser filtered against UserName + UserPassword
        // refresh row to db
        // return dsUser() object
        dsUser DS = new dsUser();
        OleDbConnection sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        OleDbDataAdapter sqlDA = new OleDbDataAdapter(
            "Select SecurityLevel from tblUserLogin " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);

        sqlDA.Fill(DS.tblUserLogin);
        return DS;
    }
    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        // new dsUserActivity() Object
        // set new dbConnection as sqlConn
        // sqlDA represents dataset from tblUserActivity sorted by most recent activity first
        // refresh row to db
        // return dsUserActivity() object
        dsPersonnel DS = new dsPersonnel();
        OleDbConnection sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        OleDbDataAdapter sqlDA;

        if (strSearch == null || strSearch.Trim() == "")
        {
            sqlDA = new OleDbDataAdapter("SELECT * FROM tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("SELECT * FROM tblPersonnel WHERE LastName = '" + strSearch + "'", sqlConn);
        }

        sqlDA.Fill(DS.tblPersonnel);
        return DS;
    }

    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;
        OleDbTransaction myTransaction = null;

        try
        {
            // set new dbConnection
            // and opens a connection
            // represent an SQL statement or stored procedure to execute against a data source.
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();

            // paramaterize SQL string
            // set value indicating how property should be interpreted
            // set SQL statement
            // execute SQL against the connection and returns number of rows affected
            // close connection
            // return 
            string strSQL;

            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            strSQL = "Insert into tblPersonnel " +
                "(FirstName, LastName) values ('" +
                FirstName + "', '" + LastName + "')";

            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();

            strSQL = "UPDATE tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate=" + StartDate + ", " +
                "EndDate=" + EndDate + ", " +
                "WHERE ID=(Select Max(ID) FROM tblPersoneel)";

            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();

            myTransaction.Commit();


            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            myTransaction.Rollback();
            recordSaved = false;
        }
        return recordSaved;
    }

    // This function saves the personnel data
    public static bool SaveUser(string Database, string UserName, string Password,
    string SecurityLevel)
    {
        bool recordSaved;
        OleDbTransaction myTransaction = null;

        try
        {
            // set new dbConnection
            // and opens a connection
            // represent an SQL statement or stored procedure to execute against a data source.
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();

            // paramaterize SQL string
            // set value indicating how property should be interpreted
            // set SQL statement
            // execute SQL against the connection and returns number of rows affected
            // close connection
            // return 
            string strSQL;

            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;


            strSQL = "Insert into tblUserLogin " +
                "(UserName, UserPassword, SecurityLevel) values ('" +
                UserName + "', '" + Password + "', '" + SecurityLevel + "')";

            
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();

            myTransaction.Commit();

            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            myTransaction.Rollback();
            recordSaved = false;
        }
        return recordSaved;
    }


    // get an IPv4 Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        // validate IPv4 server family support
        // retrieve host IPv4 address from specific HTTP request
        foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        // retrieve host IPv4 from localhost
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }

}