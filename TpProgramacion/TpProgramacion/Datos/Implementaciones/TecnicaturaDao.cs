using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TpProgramacion.Dominio;

namespace TpProgramacion.Datos
{
    internal class TecnicaturaDao : ITecnicaturaDao
    {
        internal List<Materias> ObtenerMaterias()
        {
            List<Materias>lMateria = new List<Materias>();
            DataTable tabla = HelperDao.GetInstance().ConsultaSelect("");
            foreach(DataRow row in tabla.Rows)
            {
                Materias m = new Materias();
                m.Nombre = row[1].ToString();
                m.Id=(int)row[0];
                lMateria.Add(m);
            }
            return lMateria;
        }

        internal int ObtenerProxima()
        {
            return HelperDao.GetInstance().ConsultarEscalar("", "@next");
        }
    }
}
