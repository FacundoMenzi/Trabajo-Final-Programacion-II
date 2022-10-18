using System;
using System.Collections.Generic;
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

        public List<Materias> ObtenerMaterias()
        {
            return dao.ObtenerMaterias();
        }

        public int ObtenerProxima()
        {
            return dao.ObtenerProxima();
        }
    }
}
