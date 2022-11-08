using DLL_API.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLL_API.Datos.Interfaces
{
    interface IMateriaDao
    {
        List<Profesor> ObtenerProfesores ();
        bool ModificarMateria(Materia mat);
        List<Materia> ObtenerMaterias(int estado);
        bool AltaBajaMaterias(Materia mat, int estado);
        bool InsertarMateria(Materia mat);
        int ObtenerProximaMateria();
    }
}
