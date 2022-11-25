using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment_6.DAL
{
    public class desgDal
    {


        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public desgDal()
        {
            //call conncetionstring;conncetion string should be set in the web.conf file
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }



        public DataTable Getdeprt(BAL.desgBal obj)
        {
            string s = "SELECT * FROM department";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable desigview(BAL.desgBal obj)
        {
            string s = "select * from designation td inner join department dt on td.departmentId=dt.departmentId";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int desgUpdate(BAL.desgBal obj)
        {
            string s = "update designation set DesignationName='" + obj.Desgination + "' where DesignationId='" + obj.DesgId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();

        }

        public int Deletedesig(BAL.desgBal obj)
        {
            string s = "delete from designation where DesignationId='" + obj.DesgId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int InsertDesig(BAL.desgBal obj)
        {
            string qry = "insert into designation values('" + obj.Desgination + "','" + obj.DepId + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

    }
}