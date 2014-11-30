using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for Common
/// </summary>
public class Common
{
    SqlConnection sqlcon;
    SqlCommand sqlcom;
    SqlDataReader dataReader;
    DataTable dataTable;

    public void openConnection()
    {
        String conString = WebConfigurationManager.ConnectionStrings["ProjectDB"].ConnectionString;
        sqlcon = new SqlConnection(conString);
        try
        { sqlcon.Open(); }
        finally { }
    }

    public int executeNonQuery(string fsqry)
    {
        int val;
        sqlcom = new SqlCommand(fsqry, sqlcon);
        try
        { val = sqlcom.ExecuteNonQuery(); }
        catch (Exception err)
        { val = 0; }
        finally { }
        return val;

    }
    /*
    public int executeScalar(string fsqry)
    {
        sqlcom = new SqlCommand(fsqry, sqlcon);
        sqlcom.CommandType = CommandType.Text;
        int val;
        try { val = int.Parse(sqlcom.ExecuteScalar().ToString()); }
        // catch { val = 0;  }
        finally { }
        return val;
    }

    public int executeScalarINT(string fsqry)
    {
        sqlcom = new SqlCommand(fsqry, sqlcon);
        sqlcom.CommandType = CommandType.Text;
        int val;
        try { val = Convert.ToInt32(sqlcom.ExecuteScalar()); }
        // catch { val = 0;  }
        finally { }
        return val;
    }
    */

    public SqlDataReader executeReader(string fsqry)
    {
        sqlcom = new SqlCommand(fsqry, sqlcon);
        sqlcom.CommandType = CommandType.Text;
        try
        {
            dataReader = sqlcom.ExecuteReader();
        }
        catch (Exception e) { }
        return dataReader;
    }
    /*
    public DataTable getTable(string fsqry)
    {
        dataTable = new DataTable();
        SqlDataAdapter dataAdap = new SqlDataAdapter();
        sqlcom = new SqlCommand(fsqry, sqlcon);
        dataAdap.SelectCommand = sqlcom;
        dataAdap.Fill(dataTable);
        return dataTable;
    }
    */
    public void closeConnection()
    {
        sqlcon.Close();
    }
}