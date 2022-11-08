using DLL_API.Datos.Implementaciones;
using DLL_API.Datos.Interfaces;
using DLL_API.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_API.Fachada
{
    public class DataAPI_Imp : IDataAPI
    {
        private IMateriaDao MatDao;
        private ITecnicaturaDao TecDao;

        public DataAPI_Imp()
        {
            TecDao = new TecnicaturaDao();
            MatDao = new MateriaDao();
        }

        public object? AltaBajaMateria(Materia mat, int estado)
        {
            bool result=false;
            if(MatDao.AltaBajaMaterias(mat, estado))
            {
                result = true;
            }
            return result;  
        }

        public object? AltaBajaTecnicatura(Tecnicatura tec, int estado)
        {
            return TecDao.AltaBajaTecnicatura(tec, estado);
        }

        public List<Materia> GetMaterias()
        {
            return MatDao.ObtenerMaterias(1);
        }
        public List<Materia> GetMateriasBajas()
        {
            return MatDao.ObtenerMaterias(0);
        }

        public List<Profesor> GetProfesores()
        {
            return MatDao.ObtenerProfesores();
        }

        public int GetProximaMateria()
        {
            return MatDao.ObtenerProximaMateria();
        }

        public int GetProximaTecnicatura()
        {
            return TecDao.ObtenerProximaTecnicatura();
        }

        public List<Tecnicatura> GetTecnicaturasAltas()
        {
            return TecDao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS", "SP_UTN_VER_DETALLES");
        }

        public List<Tecnicatura> GetTecnicaturasBajas()
        {
            return TecDao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS_BAJAS", "SP_UTN_VER_DETALLES");
        }

        public object? SaveMateria(Materia materia)
        {
            return MatDao.InsertarMateria(materia);
        }

        public bool SaveTecnicatura(Tecnicatura tecnicatura)
        {
            return TecDao.InsertarTecnicatura(tecnicatura);
        }

        public object? UpdateMateria(Materia mat)
        {
            return MatDao.ModificarMateria(mat);
        }

        public object? UpdateTecnicatura(Tecnicatura tec)
        {
            return TecDao.ModificarTecnicatura(tec);
        }
    }
}
