using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

class DataAccess : IDataAccess
{

   
    string connStr = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
    public object GetSingleAnswer1(string sql,string c,int sid,int i)
    {

        SqlConnection conn = new SqlConnection(connStr);
        object obj = null;
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@course", c);
            cmd.Parameters.AddWithValue("@id", sid);
            cmd.Parameters.AddWithValue("@sec", i);
            obj = cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();

        }
        return obj;
    }    
    public object GetSingleAnswer(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        object obj = null;
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            obj = cmd.ExecuteScalar();
        }
        catch(Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();

        }
        return obj;
    }

    public DataTable GetManyRowCols(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        DataTable dt = new DataTable();
        try
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return dt;
        }




    public int InsertUpdateDelete(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        int rowModified = 0;

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            rowModified = cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return rowModified;
    }
}
