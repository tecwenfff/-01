using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
//using System.Windows.Forms;
namespace LessonDal
{
    public class SqlDbHelper
    {
        private String connectString;
        public String ConnectString 
        {
            set { connectString = value; }
            get { return connectString; }
        }
        public SqlDbHelper()
        {
            this.connectString = ConfigurationManager.ConnectionStrings["DataConn"].ConnectionString;
        }
        public SqlDbHelper(string constr)
        {
            this.connectString = constr;
        }
        public int ExecuteNonquery(String strSql, CommandType commandType,params SqlParameter[] parameters)
        {
            int count;
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, con))
                {
                    cmd.CommandType = commandType;
                  //  cmd.CommandText = strSql;
                    if (parameters != null)
                    {
                        foreach (SqlParameter pa in parameters)
                        { cmd.Parameters.Add(pa); }
                    }
                    con.Open();
                    count=cmd.ExecuteNonQuery();
                }
            }
            return count;
        }
        public int ExecuteNonquery(String strSql, CommandType commandType)
        {
            return ExecuteNonquery(strSql, commandType, null);
        }
        public int ExecuteNonquery(String strSql)
        {
            return ExecuteNonquery(strSql, CommandType.Text);
        }
        public Object ExecuteScalar(String strSql, CommandType commandType, params  SqlParameter[] parameters)
        {
            Object obj;
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, con))
                {
                    cmd.CommandType = commandType;
                  //  cmd.CommandText = strSql;
                    if (parameters != null)
                    {
                        foreach (SqlParameter pa in parameters)
                        { cmd.Parameters.Add(pa); }
                    }
                    con.Open();
                    obj = cmd.ExecuteScalar();
                }
            }
            return obj;
        }
        public Object ExecuteScalar(String strSql, CommandType commandType)
        {
            return ExecuteScalar(strSql, commandType, null);
        }
        public Object ExecuteScalar(String strSql)
        {
            return ExecuteScalar(strSql, CommandType.Text, null);
        }
        public static SqlDataReader ExecuteReader(String strSql, CommandType commandType, SqlConnection con,params  SqlParameter[] parameters)
        {
            SqlDataReader reader;
          // con = new SqlConnection(ConnectString);
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.CommandType = commandType;
            //  cmd.CommandText = strSql;
            if (parameters != null)
            {
                foreach (SqlParameter pa in parameters)
                { cmd.Parameters.Add(pa); }
            }
            con.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public SqlDataReader ExecuteReader(String strSql, CommandType commandType)
        {
            return ExecuteReader(strSql, commandType, null);
        }
        public SqlDataReader ExecuteReader(String strSql)
        {
            return ExecuteReader(strSql,CommandType.Text);
        }
        public static SqlDataAdapter ExecuteAdapter(String strSql, CommandType commandType, SqlConnection con,params  SqlParameter[] parameters)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand(strSql, con);
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (SqlParameter pa in parameters)
                    { cmd.Parameters.Add(pa); }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                return adapter;
            }
            catch (SqlException ex)
            {
              //  MessageBox.Show(ex.Message);
                return null;
            }
        }
        public  DataTable ExecuteDataTable(String strSql, CommandType commandType,  params  SqlParameter[] parameters)
        {
            DataTable table=new DataTable ();
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, con))
                {
                    cmd.CommandType = commandType;
                    //  cmd.CommandText = strSql;
                    if (parameters != null)
                    {
                        foreach (SqlParameter pa in parameters)
                        { cmd.Parameters.Add(pa); }
                    }
                    con.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
    }
}
