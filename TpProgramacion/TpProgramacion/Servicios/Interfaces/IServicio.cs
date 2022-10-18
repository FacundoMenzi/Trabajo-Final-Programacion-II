using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpProgramacion.Dominio;

namespace TpProgramacion.Servicios.Interfaces
{
    internal interface IServicio
    {
        List<Materias> ObtenerMaterias();
        int ObtenerProxima();
    }
}
