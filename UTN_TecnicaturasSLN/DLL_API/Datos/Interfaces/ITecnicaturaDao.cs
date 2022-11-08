using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DLL_API.Dominio;

namespace DLL_API.Datos.Interfaces
{
    interface ITecnicaturaDao
    {
        //List<Materia> ObtenerMaterias();
        bool ModificarTecnicatura(Tecnicatura tec);
        List<Tecnicatura> ObtenerTecnicaturas(string SPTec, string SPDetalles);
        bool AltaBajaTecnicatura(Tecnicatura tec, int estado);
        bool InsertarTecnicatura(Tecnicatura tec);
        int ObtenerProximaTecnicatura();

    }
}
