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
        public List<Materia> GetMaterias();
        public List<Materia> GetMateriasBajas();
        public bool SaveTecnicatura(Tecnicatura tecnicatura);
        List<Tecnicatura> GetTecnicaturasAltas();
        List<Tecnicatura> GetTecnicaturasBajas();
        object? UpdateTecnicatura(Tecnicatura tec);
        object? AltaBajaTecnicatura(Tecnicatura tec, int v);
        int GetProximaTecnicatura();
        List<Profesor> GetProfesores();
        int GetProximaMateria();
        object? SaveMateria(Materia materia);
        object? UpdateMateria(Materia mat);
        object? AltaBajaMateria(Materia mat, int v);
    }
}
