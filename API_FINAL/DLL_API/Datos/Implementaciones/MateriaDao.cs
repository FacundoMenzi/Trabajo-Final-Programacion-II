using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DLL_API.Datos.Interfaces;
using DLL_API.Dominio;

namespace DLL_API.Datos.Implementaciones
{

    public class MateriaDao : IMateriaDao
    {
        SqlTransaction t = null;


        public bool AltaBajaMaterias(Materia mat, int estado)
        {
            bool result = true;
            SqlConnection conn = HelperDao.GetInstance().ObtenerConexion();
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_UTN_ALTA_BAJA_MATERIAS", conn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;

                t = conn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@id_materia", mat.Id);
                cmd.Parameters.AddWithValue("@estado", estado);
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
       

        public bool InsertarMateria(Materia mat)
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
                cmd.CommandText = "SP_UTN_INSERTAR_MATERIA";
                t = con.BeginTransaction();
                cmd.Transaction = t;

                cmd.Parameters.AddWithValue("@nombre", mat.Nombre);
                cmd.Parameters.AddWithValue("@id_profesor", mat.Profesor.Id);
                cmd.Parameters.AddWithValue("@id_turno", mat.IdTurno);
                cmd.Parameters.AddWithValue("@estado", mat.Estado);

                cmd.ExecuteNonQuery();
               
                cmd.Parameters.Clear();
                result = true;
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                result = false;
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

        public bool ModificarMateria(Materia mat)
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
                cmd.CommandText = "SP_UTN_MODIFICAR_MATERIAS";
                t = con.BeginTransaction();
                cmd.Transaction = t;

                cmd.Parameters.AddWithValue("@id_materia_", mat.Id);
                cmd.Parameters.AddWithValue("@nombre", mat.Nombre);
                cmd.Parameters.AddWithValue("@id_profesor", mat.Profesor.Id);
                cmd.Parameters.AddWithValue("@id_turno", mat.IdTurno);
                

                cmd.ExecuteNonQuery();
                

                cmd.Parameters.Clear();
                result = true;
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                result = false;
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

        public List<Materia> ObtenerMaterias(int estado)
        {
            List<Materia> lMateria = new List<Materia>();
            List<Parametro> lP=new List<Parametro>();
            lP.Add(new Parametro("@estado", estado));
            
            DataTable tabla = HelperDao.GetInstance().Select("SP_UTNVER_MATERIAS", lP);
            foreach (DataRow row in tabla.Rows)
            {
                Profesor p = new Profesor();
                p.Id = (int)row["id_profesor"];
                p.Nombre = row["profesor"].ToString();
                Materia m = new Materia();
                m.Id = (int)row["id_materia"];
                m.Nombre = row["nombre"].ToString();
                m.Profesor = p;
                m.IdTurno = (int)row["id_turno"];
                m.Estado = estado;


                lMateria.Add(m);
            }
            return lMateria;
        }

        public List<Profesor> ObtenerProfesores()
        {
            List<Profesor> lProfesores = new List<Profesor>();
            DataTable tabla = HelperDao.GetInstance().Select("SP_OBTENER_PROFESORES", null);
            foreach (DataRow row in tabla.Rows)
            {
                Profesor p = new Profesor();
                p.Nombre = row[1].ToString();
                p.Id = (int)row[0];
                
                lProfesores.Add(p);
            }
            return lProfesores;
        }

        public int ObtenerProximaMateria()
        {
            return HelperDao.GetInstance().ConsultarEscalar("SP_UTN_PROXIMA_MATERIA", "@next");
        }

    }
}
