using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNetFramework
{
    internal class HelperFramework
    {
        private static HelperFramework _instance;
        private SqlConnection conn;
        private HelperFramework()
        {
            conn=new SqlConnection(Properties.Resources.cnnString);
        }
        public static HelperFramework Instance()
        {
            if( _instance == null)
            {
                _instance= new HelperFramework();
            }
            return _instance;
        }
        //public DataTable LoadReport(string SP)
        //{
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = SP;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    dt.Load(cmd.ExecuteReader());
        //    conn.Close();
        //    return dt;
        //}
        public DataTable LoadReport(string SP,List<ParametroFramework> values)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();

            cmd.Connection = conn;
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            if (values != null)
            {
                foreach (ParametroFramework oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;
        }
    }
}
