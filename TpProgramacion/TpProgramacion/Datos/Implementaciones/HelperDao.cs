using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace TpProgramacion.Datos
{
    internal class HelperDao : IDao
    {
        private static HelperDao instance;

        SqlConnection conn;
        SqlCommand cmd= new SqlCommand();
        SqlTransaction trs = null;
        private HelperDao()
        {
            conn = new SqlConnection(Properties.Resources.cnnString);
          
        }
        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        internal int ConsultarEscalar(string SP, string Nparam)
        {
           
            Conectar();
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut=new SqlParameter(@Nparam, DbType.Int32);
            pOut.Direction=ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            desconectar();
            return (int)pOut.Value;
        }

        internal DataTable ConsultaSelect(string SP)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());    
            desconectar();
            return tabla;
        }

        private void Conectar()
        {
            conn.Open();
            cmd.Connection = conn;
        }
        private void desconectar()
        {
            conn.Close();
        }
    }
}
