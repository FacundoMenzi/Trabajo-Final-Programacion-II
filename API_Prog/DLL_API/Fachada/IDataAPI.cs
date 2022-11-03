using DLL_API.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_API.Fachada
{
    public interface IDataAPI
    {
        public List<Materias> GetMaterias();
        public bool SaveTecnicatura(Tecnicatura tecnicatura);
        List<Tecnicatura> GetTecnicaturasAltas();
        List<Tecnicatura> GetTecnicaturasBajas();
        object? UpdateTecnicatura(Tecnicatura tec);
        object? BajaTecnicatura(Tecnicatura tec, int v);
    }
}
