using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TpProgramacion.Dominio;

namespace TpProgramacion.Datos
{
    interface ITecnicaturaDao
    {
        List<Materias> ObtenerMaterias();
        bool ModificarTecnicatura(Tecnicatura tec);
        List<Tecnicatura> ObtenerTecnicaturas(string SPTec, string SPDetalles);
        bool AltaBajaTecnicatura(Tecnicatura tec, int estado);
        bool InsertarTecnicatura(Tecnicatura tec);
        int ObtenerProximaTecnicatura();

    }
}
