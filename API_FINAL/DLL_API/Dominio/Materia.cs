using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_API.Dominio
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdTurno { get; set; }
        public int Estado { get; set; }
        public Profesor Profesor { get; set; }
        public Materia()
        {
        }
        public Materia(int id,string nom)
        {
            Id = id;
            Nombre = nom;
            
        }

    }
}
