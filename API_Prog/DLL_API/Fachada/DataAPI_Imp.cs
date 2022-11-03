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
        private ITecnicaturaDao dao;

        public DataAPI_Imp()
        {
            dao = new TecnicaturaDao();
        }

        public object? BajaTecnicatura(Tecnicatura tec, int v)
        {
            return dao.AltaBajaTecnicatura(tec, v);
        }

        public List<Materias> GetMaterias()
        {
            return dao.ObtenerMaterias();
        }

        public List<Tecnicatura> GetTecnicaturasAltas()
        {
            return dao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS", "SP_UTN_VER_DETALLES");
        }

        public List<Tecnicatura> GetTecnicaturasBajas()
        {
            return dao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS_BAJAS", "SP_UTN_VER_DETALLES");
        }

        public bool SaveTecnicatura(Tecnicatura tecnicatura)
        {
            return dao.InsertarTecnicatura(tecnicatura);
        }

        public object? UpdateTecnicatura(Tecnicatura tec)
        {
            return dao.ModificarTecnicatura(tec);
        }
    }
}
