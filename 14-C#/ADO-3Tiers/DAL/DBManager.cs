using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;
using System;
using System.Diagnostics;

namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlcn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DBManager()
        {
            try
            {
                this.sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["pubsCon"].ConnectionString);
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcn;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
            }
            catch
            {
                Debug.WriteLine("ERROR IN DB CONNECTION");

            }

        }
        //Update or delete or insert
        //Withot paramerter
        public int ExexuteNonQuery(string spName)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                {
                    sqlcn.Open();
                }
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                Debug.WriteLine("ERROR IN ExecuteNonQuery");
                return -1;
            }
            finally
            {

                sqlcn.Close();
            }

        } 
        //Update or delete or insert
        //Withot paramerter
        public int ExexuteNonQuery(string spName, Dictionary<string, object> ParmLst)
        {
            try
            {
                cmd.Parameters.Clear();
                foreach (var par in ParmLst) cmd.Parameters.Add(new SqlParameter( par.Key, par.Value));
                cmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                {
                    sqlcn.Open();
                }
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                Debug.WriteLine("ERROR IN ExecuteNonQuery");
                return -1;
            }
            finally
            {

                sqlcn.Close();
            }

        }
        public Object ExexuteScaler(string spName)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText= spName;
                if (sqlcn.State == ConnectionState.Closed)
                {
                    sqlcn.Open();
                }
                return cmd.ExecuteScalar();
            }
            catch
            {
                Debug.WriteLine("ERROR IN ExecuteScaler");

                return new();
            }
            finally
            {
                sqlcn.Close();
            }

        }
        public DataTable ExecuteDataTable(string spName)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = spName;
                da.Fill(dt);

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();
                Debug.WriteLine("hello from try");
                Debug.WriteLine(dt.Rows.Count);

                return dt;

            }
            catch
            {
                Debug.WriteLine("hello from catch");

                return new();
            }
            finally { 
                sqlcn.Close();
            }


}
    }
}