using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpProgramacion.Datos;
using TpProgramacion.Dominio;
using TpProgramacion.Servicios.Interfaces;

namespace TpProgramacion.Servicios.Implementaciones
{
    internal class Servicio: IServicio
    {
        TecnicaturaDao dao=new TecnicaturaDao();

        public bool CrearTecnicatura(Tecnicatura tecnicatura)
        {
            return dao.InsertarTecnicatura(tecnicatura);
        }

        public bool DarBaja(Tecnicatura tecnicatura)
        {
            return dao.AltaBajaTecnicatura(tecnicatura,0);
        }
        public void DarAlta(Tecnicatura tecnicatura)
        {
            dao.AltaBajaTecnicatura(tecnicatura,1);
        }

        public bool ModificarTecnicatura(Tecnicatura c)
        {
            return dao.ModificarTecnicatura(c);
        }


        public List<Materias> ObtenerMaterias()
        {
            return dao.ObtenerMaterias();
        }

        public int ObtenerProximaTecnicatura()
        {
            return dao.ObtenerProximaTecnicatura();
        }

        public List<Tecnicatura> CargarListaTecnicaturas()
        {
            return dao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS", "SP_UTN_VER_DETALLES");
        }

        public List<Tecnicatura> CargarListaTecnicaturasBajas()
        {
            return dao.ObtenerTecnicaturas("SP_UTN_VER_TECNICATURAS_BAJAS", "SP_UTN_VER_DETALLES");
        }

        
    }
}
