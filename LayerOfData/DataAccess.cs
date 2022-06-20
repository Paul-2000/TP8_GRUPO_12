using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LayerOfData
{
    public class DataAccess
    {
        private string routeBDSucursales = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        public DataAccess(){}
        private SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(routeBDSucursales);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            { 
                return null;
            }
        }
        private SqlDataAdapter getAdapter(string query, SqlConnection cn)
        {
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(query, cn);
                return adapter;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int ExecuteReader(string strSQL)
        {
            SqlConnection sqlConnection = new SqlConnection(routeBDSucursales);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(strSQL, sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sqlConnection.Close();
                return 1;
            }
            else
            {
                sqlConnection.Close();
                return -1;
            }
        }
        public DataTable getTable(string tableName, string sql)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = getConnection();
            SqlDataAdapter adapter = getAdapter(sql, cn);
            adapter.Fill(ds, tableName);
            cn.Close();
            return ds.Tables[tableName];
        }
        public int executeStoredProcedure(SqlCommand command, string spName)
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd = command;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            int changedRow = cmd.ExecuteNonQuery();
            cn.Close();
            return changedRow;
        }
        public bool exists(string query)
        {
            Boolean status = false;
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader data = cmd.ExecuteReader();
            if(data.Read()) status = true;
            return status;
        }
        public int getMax(string query)
        {
            int max = 0;
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader data = cmd.ExecuteReader();
            if(data.Read()) max = Convert.ToInt32(data[0].ToString());
            return max;
        }
        public SqlDataReader ddlCharger(string query)
        {
            SqlConnection cn = new SqlConnection(routeBDSucursales);
            cn.Open();
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataReader dr = command.ExecuteReader();
            return dr;
        }
    }
}