using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TpProgramacion.Datos
{
    internal interface IDao
    {
        SqlConnection ObtenerConexion();
        int ConsultarEscalar(string SP, string Nparam);
        DataTable Select(string SP, List<Parametro> values);

    }
}
