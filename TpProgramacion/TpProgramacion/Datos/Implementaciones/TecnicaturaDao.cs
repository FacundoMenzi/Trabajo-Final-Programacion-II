using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TpProgramacion.Dominio;
using System.Data.SqlClient;

namespace TpProgramacion.Datos
{
    internal class TecnicaturaDao :ITecnicaturaDao
    {
        SqlTransaction t=null;
        public List<Materias> ObtenerMaterias()
        {
            List<Materias> lMateria = new List<Materias>();
            DataTable tabla = HelperDao.GetInstance().Select("SP_UTNVER_MATERIAS", null);
            foreach (DataRow row in tabla.Rows)
            {
                Materias m = new Materias();
                m.Nombre = row[1].ToString();
                m.Id = (int)row[0];
                lMateria.Add(m);
            }
            return lMateria;
        }
        public bool InsertarTecnicatura(Tecnicatura tec)
        {
            bool result;
            SqlConnection con = HelperDao.GetInstance().ObtenerConexion();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_UTN_INSERTAR_MAESTRO";
                t = con.BeginTransaction();
                cmd.Transaction = t;

                SqlParameter pOUT = new SqlParameter("@id_tecnicatura", DbType.Int32);
                pOUT.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOUT);

                cmd.Parameters.AddWithValue("@nombre", tec.Nombre);
                cmd.Parameters.AddWithValue("@titulo", tec.Titulo);
                cmd.Parameters.AddWithValue("@estado", tec.Estado);

                cmd.ExecuteNonQuery();

                int id_tecnicatura = (int)pOUT.Value;

                foreach (DetalleTecnicatura detalle in tec.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand();
                    cmdDet.Connection = con;
                    cmdDet.Transaction = t;
                    cmdDet.CommandText = "SP_INSERTAR_UTN_DETALLE";
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@id_tecnicatura", id_tecnicatura);
                    cmdDet.Parameters.AddWithValue("@id_materia", detalle.Materia.Id);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", detalle.Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@anio", detalle.AñoCursado);


                    cmdDet.ExecuteNonQuery();
                }
                cmd.Parameters.Clear();
                result = true;
                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                result = false;
                throw ex;
            }
            finally
            {
                if (con != null & con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public bool ModificarTecnicatura(Tecnicatura tec)
        {
            bool result = true;
            SqlConnection conn = HelperDao.GetInstance().ObtenerConexion();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_UTN_MODIFICAR", conn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;

                t = conn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@idTecnicatura_", tec.Id);
                cmd.Parameters.AddWithValue("@nombre", tec.Nombre);
                cmd.Parameters.AddWithValue("@titulo", tec.Titulo);
                cmd.ExecuteNonQuery();
                foreach (DetalleTecnicatura detalle in tec.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand();
                    cmdDet.Connection = conn;
                    cmdDet.Transaction = t;
                    cmdDet.CommandText = "SP_INSERTAR_UTN_DETALLE";
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@id_tecnicatura", tec.Id);
                    cmdDet.Parameters.AddWithValue("@id_materia", detalle.Materia.Id);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", detalle.Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@anio", detalle.AñoCursado);


                    cmdDet.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                result = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;

        }
        public bool AltaBajaTecnicatura(Tecnicatura tec,int estado)
        {
            bool result = true;
            SqlConnection conn = HelperDao.GetInstance().ObtenerConexion();
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_UTN_ALTA_BAJA", conn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;

                t = conn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@idTecnicatura_", tec.Id);
                cmd.Parameters.AddWithValue("@estado",estado);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                result = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        public List<Tecnicatura> ObtenerTecnicaturas(string SPTec,string SPDetalles)
        {
            List<Tecnicatura> lTecnicatura = new List<Tecnicatura>();
            
            DataTable Tcarrera = HelperDao.GetInstance().Select(SPTec, null); //Se ejecuta el SP TEC
            
            foreach (DataRow fila in Tcarrera.Rows)
            {
                Tecnicatura t = new Tecnicatura();
                t.Nombre = fila["nombre"].ToString();
                t.Titulo = fila["titulo"].ToString();
                t.Id = Convert.ToInt32(fila["id_tecnicatura"]);
                t.Estado = Convert.ToInt32(fila["estado"]);

                List<Parametro> lstDetalles = new List<Parametro>();
                lstDetalles.Add(new Parametro("@idTecnicatura_", t.Id));
                
                DataTable Tdetalle = HelperDao.GetInstance().Select(SPDetalles, lstDetalles); // SP DETALLES

                foreach (DataRow Detallefila in Tdetalle.Rows)
                {
                    DetalleTecnicatura d = new DetalleTecnicatura();
                    d.AñoCursado = Convert.ToInt32(Detallefila["anio_cursado"]);
                    d.Cuatrimestre = Convert.ToInt32(Detallefila["cuatrimestre"]);
                    int idMat = Convert.ToInt32(Detallefila["id_materia"]);
                    string nomMat = Detallefila["nombre"].ToString();
                    Materias m = new Materias(idMat, nomMat);
                    d.Materia = m;
                    t.Agregar(d);
                }
                lTecnicatura.Add(t);

            }
            return lTecnicatura;
        }
        public int ObtenerProximaTecnicatura()
        {
            return HelperDao.GetInstance().ConsultarEscalar("SP_UTN_PROXIMO", "@next");
        }

    }
}
