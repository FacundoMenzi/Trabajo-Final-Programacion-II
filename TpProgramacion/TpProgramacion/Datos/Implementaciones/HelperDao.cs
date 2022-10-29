using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TpProgramacion.Dominio;

namespace TpProgramacion.Datos
{
    internal class HelperDao : IDao
    {
        private static HelperDao instance;

        SqlConnection conn;
        SqlCommand cmd= new SqlCommand();
        private HelperDao()
        {
            conn = new SqlConnection(Properties.Resources.cnnString);
          
        }
        public SqlConnection ObtenerConexion()
        {
            return conn;
        }
        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public int ConsultarEscalar(string SP, string Nparam)
        {
            Conectar();
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut=new SqlParameter(@Nparam, DbType.Int32);
            pOut.Direction=ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            Desconectar();
            return (int)pOut.Value;
        }

        public DataTable Select(string SP,List<Parametro> values)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());    
            Desconectar();
            return tabla;
        }
        

        private void Conectar()
        {
            conn.Open();
            cmd.Connection = conn;
        }
        private void Desconectar()
        {
            conn.Close();
        }

        
    }
}
