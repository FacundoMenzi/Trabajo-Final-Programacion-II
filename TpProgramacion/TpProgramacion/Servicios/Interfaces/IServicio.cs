using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpProgramacion.Dominio;

namespace TpProgramacion.Servicios.Interfaces
{
    internal interface IServicio
    {
        List<Materias> ObtenerMaterias();
        int ObtenerProximaTecnicatura();
        bool CrearTecnicatura(Tecnicatura tecnicatura);
        List<Tecnicatura> CargarListaTecnicaturas();
        bool DarBaja(Tecnicatura tecnicatura);
        bool ModificarTecnicatura(Tecnicatura c);
        List<Tecnicatura> CargarListaTecnicaturasBajas();
        void DarAlta(Tecnicatura tecnicatura);
    }
}
