using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectDB
/// </summary>
public class ConnectDB
{
    private string strConnection()
    {
        // return "Data Source=10.20.5.89;Initial Catalog=CIP;User ID=CIPAdmin;Password=a36pYcs4";
        return "Data Source=(local);Initial Catalog=CIP;User ID=maijingjing;Password=P@ssw0rd";
    }

    public SqlConnection connection()
    {
        SqlConnection conn = new SqlConnection(strConnection());
        return conn;
    }

    internal void ExecuteData(string sql, SqlParameterCollection param)
    {
        throw new NotImplementedException();
    }


    public static DataTable GetData(string sql, string tblName)
    {
        SqlConnection conn = new ConnectDB().connection();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, tblName);
        return ds.Tables[0];
    }

    public static DataTable GetData(string sql, string tblName, SqlParameterCollection parameters)
    {
        SqlConnection conn = new ConnectDB().connection();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        foreach (SqlParameter param in parameters)
        {
            da.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.Value);
        }
        da.Fill(ds, tblName);
        return ds.Tables[0];
    }

    public static int ExecuteData(string sql)
    {
        int i;
        SqlConnection conn = new db().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }

    public static int ExecuteDataReturnID(string sql)
    {
        int i;
        SqlConnection conn = new ConnectDB().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        conn.Open();
        i = (int)cmd.ExecuteScalar();
        conn.Close();
        return i;
    }

    public static int ExecuteDataReturnID(string sql, SqlParameterCollection parameters)
    {
        int i;
        SqlConnection conn = new ConnectDB().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }
        conn.Open();
        i = (int)cmd.ExecuteScalar();
        conn.Close();
        return i;
    }

    public static int ExecuteData(string sql, SqlParameterCollection parameters)
    {
        int i;
        SqlConnection conn = new ConnectDB().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }
        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }

    public static DataSet ExcStorePro(string stpName, string tblName, SqlParameterCollection parameters)
    {
        SqlConnection conn = new ConnectDB().connection();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = stpName;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, tblName);
        return ds;
    }

}